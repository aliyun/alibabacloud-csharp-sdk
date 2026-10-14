// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application address groups. You can specify this parameter when ConfigMode is Precise. You cannot specify this parameter when ConfigMode is an empty string.</para>
        /// </summary>
        [NameInMap("AddressGroups")]
        [Validation(Required=false)]
        public List<AddressGroup> AddressGroups { get; set; }

        /// <summary>
        /// <para>The collection of private access application addresses. You can enter up to 1,000 private access application addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>The ID of the private access application. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: Lists private access applications.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: Creates a private access application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The configuration mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Empty string: the default mode.</description></item>
        /// <item><description>Precise: the precise mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Precise</para>
        /// </summary>
        [NameInMap("ConfigMode")]
        [Validation(Required=false)]
        public string ConfigMode { get; set; }

        /// <summary>
        /// <para>The description of the private access application. The description must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a private access application</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The health check configuration. This parameter is valid only when HealthCheckMode is set to Continuous. You cannot specify this parameter when HealthCheckMode is set to OnAccess.</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfigShrink { get; set; }

        /// <summary>
        /// <para>The health check mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OnAccess: Checks upon access without active probing.</description></item>
        /// <item><description>Continuous: Performs continuous checks and periodically probes based on the configurations in HealthCheckConfig.
        /// If this parameter is not specified, the default value is OnAccess. When the application addresses include wildcard domain names or CIDR blocks, or when the number of application addresses exceeds 10, only OnAccess is supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OnAccess</para>
        /// </summary>
        [NameInMap("HealthCheckMode")]
        [Validation(Required=false)]
        public string HealthCheckMode { get; set; }

        /// <summary>
        /// <para>The Layer 7 application configuration in browser access mode.</para>
        /// </summary>
        [NameInMap("L7Config")]
        [Validation(Required=false)]
        public string L7ConfigShrink { get; set; }

        /// <summary>
        /// <para>The prefix of the mapped proxy domain name in browser access mode. The prefix must be 3 to 20 characters in length, and can contain lowercase letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1-xxx</para>
        /// </summary>
        [NameInMap("L7ProxyDomainAutomaticPrefix")]
        [Validation(Required=false)]
        public string L7ProxyDomainAutomaticPrefix { get; set; }

        /// <summary>
        /// <para>The custom proxy domain name in browser access mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1.example.com</para>
        /// </summary>
        [NameInMap("L7ProxyDomainCustom")]
        [Validation(Required=false)]
        public string L7ProxyDomainCustom { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The private proxy domain name in browser access mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1.example.com</para>
        /// </summary>
        [NameInMap("L7ProxyDomainPrivate")]
        [Validation(Required=false)]
        [Obsolete]
        public string L7ProxyDomainPrivate { get; set; }

        /// <summary>
        /// <para>The modification type of the private access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default): Overwrites the original addresses, port ranges, and tag IDs with the values of the <b>Addresses</b>, <b>PortRanges</b>, and <b>TagIds</b> parameters.</description></item>
        /// <item><description><b>Append</b>: Appends the values specified in the <b>Addresses</b>, <b>PortRanges</b>, and <b>TagIds</b> parameters to the original addresses, port ranges, and tag IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private_access_application_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The collection of port ranges for the private access application. You can enter up to 65,535 port ranges. Multiple port ranges cannot be duplicate or overlap.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessApplicationShrinkRequestPortRanges> PortRanges { get; set; }
        public class UpdatePrivateAccessApplicationShrinkRequestPortRanges : TeaModel {
            /// <summary>
            /// <para>The start port. The value must be less than or equal to the end port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <para>The end port. The value must be greater than or equal to the start port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

        /// <summary>
        /// <para>The protocol of the private access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: All protocols.</description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The status of the private access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The collection of private access tag IDs. You can associate up to six custom private access tags with a single private access application.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// <para>The configuration for unauthorized application access requests.</para>
        /// </summary>
        [NameInMap("UnauthorizedAccessConfig")]
        [Validation(Required=false)]
        public string UnauthorizedAccessConfigShrink { get; set; }

    }

}
