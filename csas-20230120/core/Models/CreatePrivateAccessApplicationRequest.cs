// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreatePrivateAccessApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The application address groups. Required when ConfigMode is set to Precise. Not allowed when ConfigMode is an empty string.</para>
        /// </summary>
        [NameInMap("AddressGroups")]
        [Validation(Required=false)]
        public List<AddressGroup> AddressGroups { get; set; }

        /// <summary>
        /// <para>The collection of internal-facing access application addresses. You can specify up to 1000 addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>The browser access status of the internal-facing access application. After this feature is enabled, you can access internal applications in a clientless manner. Default value: <b>Disabled</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled.</description></item>
        /// <item><description><b>Disabled</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("BrowserAccessStatus")]
        [Validation(Required=false)]
        public string BrowserAccessStatus { get; set; }

        /// <summary>
        /// <para>The configuration mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Empty string: default mode.</description></item>
        /// <item><description>Precise: precise mode.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ConfigMode")]
        [Validation(Required=false)]
        public string ConfigMode { get; set; }

        /// <summary>
        /// <para>The description of the internal-facing access application. The description must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. Chinese characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an internal-facing access application</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter: the application configuration.</para>
        /// </summary>
        [NameInMap("L7Config")]
        [Validation(Required=false)]
        public PAL7Config L7Config { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter: the prefix of the mapped proxy domain name. The prefix must be 3 to 20 characters in length and can contain lowercase letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-sample</para>
        /// </summary>
        [NameInMap("L7ProxyDomainAutomaticPrefix")]
        [Validation(Required=false)]
        public string L7ProxyDomainAutomaticPrefix { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter: the custom proxy domain name. The value must be a valid domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1.example.com</para>
        /// </summary>
        [NameInMap("L7ProxyDomainCustom")]
        [Validation(Required=false)]
        public string L7ProxyDomainCustom { get; set; }

        /// <summary>
        /// <para>The name of the internal-facing access application. The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). Chinese characters are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private_access_application_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The collection of port ranges for the internal-facing access application. You can specify up to 65535 port ranges. Port ranges cannot overlap or be duplicated.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreatePrivateAccessApplicationRequestPortRanges> PortRanges { get; set; }
        public class CreatePrivateAccessApplicationRequestPortRanges : TeaModel {
            /// <summary>
            /// <para>The start port. The value must be less than or equal to the end port.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <para>The end port. The value must be greater than or equal to the start port.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

        /// <summary>
        /// <para>The protocol of the internal-facing access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: all protocols.</description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The status of the internal-facing access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled.</description></item>
        /// <item><description><b>Disabled</b>: disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The collection of internal-facing access tag IDs. You can associate up to 6 custom-type internal-facing access tags with each application.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        [NameInMap("UnauthorizedAccessConfig")]
        [Validation(Required=false)]
        public PAApplicationUnauthorizedAccessConfig UnauthorizedAccessConfig { get; set; }

    }

}
