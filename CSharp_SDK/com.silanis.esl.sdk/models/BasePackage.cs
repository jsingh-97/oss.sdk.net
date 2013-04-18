//
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
public class BasePackage
{
    
    // Fields
    private IList<Document> _documents = new List<Document>();
    private IList<Message> _messages = new List<Message>();
    private IList<Role> _roles = new List<Role>();
    
    // Accessors
        
    [JsonProperty("autocomplete")]
    public Boolean Autocomplete
    {
                get; set;
        }
    
        
    [JsonProperty("consent")]
    public String Consent
    {
                get; set;
        }
    
        
    [JsonProperty("data")]
    public IDictionary<string, object> Data
    {
                get; set;
        }
    
        
    [JsonProperty("description")]
    public String Description
    {
                get; set;
        }
    
        
    [JsonProperty("documents")]
    public IList<Document> Documents
    {
                get
        {
            return _documents;
        }
        }
        public BasePackage AddDocument(Document value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Argument cannot be null");
        }
        
        _documents.Add(value);
        return this;
    }
    
        
    [JsonProperty("due")]
    public Nullable<DateTime> Due
    {
                get; set;
        }
    
        
    [JsonProperty("emailMessage")]
    public String EmailMessage
    {
                get; set;
        }
    
        
    [JsonProperty("id")]
    public String Id
    {
                get; set;
        }
    
        
    [JsonProperty("limits")]
    public PackageArtifactsLimits Limits
    {
                get; set;
        }
    
        
    [JsonProperty("messages")]
    public IList<Message> Messages
    {
                get
        {
            return _messages;
        }
        }
        public BasePackage AddMessage(Message value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Argument cannot be null");
        }
        
        _messages.Add(value);
        return this;
    }
    
        
    [JsonProperty("name")]
    public String Name
    {
                get; set;
        }
    
        
    [JsonProperty("roles")]
    public IList<Role> Roles
    {
                get
        {
            return _roles;
        }
        }
        public BasePackage AddRole(Role value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Argument cannot be null");
        }
        
        _roles.Add(value);
        return this;
    }
    
        
    [JsonProperty("sender")]
    public Sender Sender
    {
                get; set;
        }
    
        
    [JsonProperty("signedDocumentDelivery")]
    public SignedDocumentDelivery SignedDocumentDelivery
    {
                get; set;
        }
    
        
    [JsonProperty("type")]
    public BasePackageType Type
    {
                get; set;
        }
    
        
    [JsonProperty("updated")]
    public Nullable<DateTime> Updated
    {
                get; set;
        }
    
    
}