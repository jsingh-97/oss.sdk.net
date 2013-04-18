//
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
public class SenderCompletionReport
{
    
    // Fields
    private IList<PackageCompletionReport> _packages = new List<PackageCompletionReport>();
    
    // Accessors
        
    [JsonProperty("packages")]
    public IList<PackageCompletionReport> Packages
    {
                get
        {
            return _packages;
        }
        }
        public SenderCompletionReport AddPackage(PackageCompletionReport value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Argument cannot be null");
        }
        
        _packages.Add(value);
        return this;
    }
    
        
    [JsonProperty("sender")]
    public Sender Sender
    {
                get; set;
        }
    
    
}