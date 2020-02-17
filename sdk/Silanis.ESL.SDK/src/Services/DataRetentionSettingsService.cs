﻿using System;
using Silanis.ESL.API;
using Silanis.ESL.SDK.Internal;
using Newtonsoft.Json;

namespace Silanis.ESL.SDK.Services
{
    public class DataRetentionSettingsService
    {
        private UrlTemplate template;
        private RestClient restClient;

        public DataRetentionSettingsService (RestClient restClient, string baseUrl)
        {
            this.restClient = restClient;
            template = new UrlTemplate (baseUrl);
        }

        /// <summary>
        /// Gets the expiry time configuration.
        /// 
        /// </summary>
        /// <returns>Expiry time configuration.</returns>
        public ExpiryTimeConfiguration GetExpiryTimeConfiguration ()
        {
            String path = template.UrlFor (UrlTemplate.EXPIRY_TIME_CONFIGURATION_PATH)
                                  .Build ();
            String stringResponse;
            try {
                stringResponse = restClient.Get (path);
            } catch (EslServerException e) {
                throw new EslServerException ("Could not get expiryTimeConfiguration." + " Exception: " + e.Message, e.ServerError, e);
            } catch (Exception e) {
                throw new EslException ("Could not get expiryTimeConfiguration." + " Exception: " + e.Message, e);
            }

            Silanis.ESL.API.ExpiryTimeConfiguration expiryTimeConfiguration = JsonConvert.DeserializeObject<Silanis.ESL.API.ExpiryTimeConfiguration> (stringResponse);
            ExpiryTimeConfigurationConverter converter = new ExpiryTimeConfigurationConverter (expiryTimeConfiguration);
            return converter.ToSDKExpiryTimeConfiguration();
        }

        /// <summary>
        /// Update expiry time configuration for account.
        /// </summary>
        /// <param name="expiryTimeConfiguration">expiryTimeConfiguration.</param>
        public void SetExpiryTimeConfiguration (ExpiryTimeConfiguration expiryTimeConfiguration)
        {
            String path = template.UrlFor (UrlTemplate.EXPIRY_TIME_CONFIGURATION_PATH)
                                  .Build ();
            ExpiryTimeConfigurationConverter converter = new ExpiryTimeConfigurationConverter (expiryTimeConfiguration);
            String expiryTimeConfigurationJson = JsonConvert.SerializeObject(converter.ToAPIExpiryTimeConfiguration ());

            try {
                restClient.Put (path, expiryTimeConfigurationJson);
            } catch (EslServerException e) {
                throw new EslServerException ("Could not update expiryTimeConfiguration" + " Exception: " + e.Message, e.ServerError, e);
            } catch (Exception e) {
                throw new EslException ("Could not update expiryTimeConfiguration" + " Exception: " + e.Message, e);
            }
        }

        /// <summary>
        /// Gets the data management policy.
        /// 
        /// </summary>
        /// <returns>Data Management Policy.</returns>
        public DataManagementPolicy GetDataManagementPolicy ()
        {
            String path = template.UrlFor (UrlTemplate.DATA_MANAGEMENT_POLICY_PATH)
                                  .Build ();
            String stringResponse;
            try {
                stringResponse = restClient.Get (path);
            } catch (EslServerException e) {
                throw new EslServerException ("Could not get dataManagementPolicy." + " Exception: " + e.Message, e.ServerError, e);
            } catch (Exception e) {
                throw new EslException ("Could not get dataManagementPolicy." + " Exception: " + e.Message, e);
            }

            Silanis.ESL.API.DataManagementPolicy dataManagementPolicy = JsonConvert.DeserializeObject<Silanis.ESL.API.DataManagementPolicy> (stringResponse);
            DataManagementPolicyConverter converter = new DataManagementPolicyConverter (dataManagementPolicy);
            return converter.ToSDKExpiryTimeConfiguration ();
        }

        /// <summary>
        /// Update data management policy for account.
        /// </summary>
        /// <param name="dataManagementPolicy">dataManagementPolicy.</param>
        public void SetDataManagementPolicy (DataManagementPolicy dataManagementPolicy)
        {
            String path = template.UrlFor (UrlTemplate.DATA_MANAGEMENT_POLICY_PATH)
                                  .Build ();
            DataManagementPolicyConverter converter = new DataManagementPolicyConverter (dataManagementPolicy);
            String dataManagementPolicyJson = JsonConvert.SerializeObject (converter.ToAPIDataManagementPolicy ());

            try {
                restClient.Put (path, dataManagementPolicyJson);
            } catch (EslServerException e) {
                throw new EslServerException ("Could not update dataManagementPolicy" + " Exception: " + e.Message, e.ServerError, e);
            } catch (Exception e) {
                throw new EslException ("Could not update dataManagementPolicy" + " Exception: " + e.Message, e);
            }
        }
    }
}
