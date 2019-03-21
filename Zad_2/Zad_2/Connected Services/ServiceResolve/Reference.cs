﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zad_2.ServiceResolve {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.cdyne.com/", ConfigurationName="ServiceResolve.IP2GeoSoap")]
    public interface IP2GeoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/ResolveIP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Zad_2.ServiceResolve.IPInformation ResolveIP(string ipAddress, string licenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/ResolveIP", ReplyAction="*")]
        System.Threading.Tasks.Task<Zad_2.ServiceResolve.IPInformation> ResolveIPAsync(string ipAddress, string licenseKey);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.cdyne.com/")]
    public partial class IPInformation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cityField;
        
        private string stateProvinceField;
        
        private string countryField;
        
        private string organizationField;
        
        private double latitudeField;
        
        private double longitudeField;
        
        private string areaCodeField;
        
        private string timeZoneField;
        
        private bool hasDaylightSavingsField;
        
        private short certaintyField;
        
        private string regionNameField;
        
        private string countryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string StateProvince {
            get {
                return this.stateProvinceField;
            }
            set {
                this.stateProvinceField = value;
                this.RaisePropertyChanged("StateProvince");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Organization {
            get {
                return this.organizationField;
            }
            set {
                this.organizationField = value;
                this.RaisePropertyChanged("Organization");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public double Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
                this.RaisePropertyChanged("Latitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public double Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
                this.RaisePropertyChanged("Longitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string AreaCode {
            get {
                return this.areaCodeField;
            }
            set {
                this.areaCodeField = value;
                this.RaisePropertyChanged("AreaCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string TimeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
                this.RaisePropertyChanged("TimeZone");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool HasDaylightSavings {
            get {
                return this.hasDaylightSavingsField;
            }
            set {
                this.hasDaylightSavingsField = value;
                this.RaisePropertyChanged("HasDaylightSavings");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public short Certainty {
            get {
                return this.certaintyField;
            }
            set {
                this.certaintyField = value;
                this.RaisePropertyChanged("Certainty");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string RegionName {
            get {
                return this.regionNameField;
            }
            set {
                this.regionNameField = value;
                this.RaisePropertyChanged("RegionName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string CountryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
                this.RaisePropertyChanged("CountryCode");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IP2GeoSoapChannel : Zad_2.ServiceResolve.IP2GeoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class P2GeoSoapClient : System.ServiceModel.ClientBase<Zad_2.ServiceResolve.IP2GeoSoap>, Zad_2.ServiceResolve.IP2GeoSoap {
        
        public P2GeoSoapClient() {
        }
        
        public P2GeoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public P2GeoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public P2GeoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public P2GeoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Zad_2.ServiceResolve.IPInformation ResolveIP(string ipAddress, string licenseKey) {
            return base.Channel.ResolveIP(ipAddress, licenseKey);
        }
        
        public System.Threading.Tasks.Task<Zad_2.ServiceResolve.IPInformation> ResolveIPAsync(string ipAddress, string licenseKey) {
            return base.Channel.ResolveIPAsync(ipAddress, licenseKey);
        }
    }
}
