// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(MySqlIdentityTypeConverter))]
    public partial class MySqlIdentity
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MySqlIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MySqlIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MySqlIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MySqlIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ServerName = (string) content.GetValueForProperty("ServerName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ServerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).FirewallRuleName = (string) content.GetValueForProperty("FirewallRuleName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).FirewallRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).VirtualNetworkRuleName = (string) content.GetValueForProperty("VirtualNetworkRuleName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).VirtualNetworkRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).DatabaseName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ConfigurationName = (string) content.GetValueForProperty("ConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ConfigurationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).LocationName = (string) content.GetValueForProperty("LocationName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).LocationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SecurityAlertPolicyName = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SecurityAlertPolicyName?) content.GetValueForProperty("SecurityAlertPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SecurityAlertPolicyName, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SecurityAlertPolicyName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).BackupName = (string) content.GetValueForProperty("BackupName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).BackupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MySqlIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ServerName = (string) content.GetValueForProperty("ServerName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ServerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).FirewallRuleName = (string) content.GetValueForProperty("FirewallRuleName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).FirewallRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).VirtualNetworkRuleName = (string) content.GetValueForProperty("VirtualNetworkRuleName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).VirtualNetworkRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).DatabaseName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ConfigurationName = (string) content.GetValueForProperty("ConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).ConfigurationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).LocationName = (string) content.GetValueForProperty("LocationName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).LocationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SecurityAlertPolicyName = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SecurityAlertPolicyName?) content.GetValueForProperty("SecurityAlertPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).SecurityAlertPolicyName, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SecurityAlertPolicyName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).BackupName = (string) content.GetValueForProperty("BackupName",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).BackupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(MySqlIdentityTypeConverter))]
    public partial interface IMySqlIdentity

    {

    }
}