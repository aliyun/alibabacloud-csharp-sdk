// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessApplicationRequest : TeaModel {
        [NameInMap("AddressGroups")]
        [Validation(Required=false)]
        public List<AddressGroup> AddressGroups { get; set; }

        /// <summary>
        /// <para>The addresses of the internal-facing access application. You can specify up to 1000 addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>The ID of the internal-facing access application. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: lists internal-facing access applications.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: creates an internal-facing access application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("ConfigMode")]
        [Validation(Required=false)]
        public string ConfigMode { get; set; }

        /// <summary>
        /// <para>The description of the internal-facing access application. The description must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条内网访问应用</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter: the Layer 7 application configuration.</para>
        /// </summary>
        [NameInMap("L7Config")]
        [Validation(Required=false)]
        public PAL7Config L7Config { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter: the prefix of the mapped proxy domain name. The prefix must be 3 to 20 characters in length and can contain lowercase letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1-xxx</para>
        /// </summary>
        [NameInMap("L7ProxyDomainAutomaticPrefix")]
        [Validation(Required=false)]
        public string L7ProxyDomainAutomaticPrefix { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter: the custom proxy domain name.</para>
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
        /// <para>The browser access mode parameter: the private proxy domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1.example.com</para>
        /// </summary>
        [NameInMap("L7ProxyDomainPrivate")]
        [Validation(Required=false)]
        [Obsolete]
        public string L7ProxyDomainPrivate { get; set; }

        /// <summary>
        /// <para>The modification type of the internal-facing access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default): overwrites the original addresses, port ranges, and tag IDs with the values of the <b>Addresses</b>, <b>PortRanges</b>, and <b>TagIds</b> parameters.</description></item>
        /// <item><description><b>Append</b>: adds the values of the <b>Addresses</b>, <b>PortRanges</b>, and <b>TagIds</b> parameters to the original addresses, port ranges, and tag IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The port ranges of the internal-facing access application. You can specify up to 65535 port ranges. Multiple port ranges cannot be duplicate or overlap.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessApplicationRequestPortRanges> PortRanges { get; set; }
        public class UpdatePrivateAccessApplicationRequestPortRanges : TeaModel {
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
        /// <para>The protocol of the internal-facing access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: all protocols.</description></item>
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
        /// <para>The status of the internal-facing access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled.</description></item>
        /// <item><description><b>Disabled</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IDs of internal-facing access tags. You can associate up to 6 custom internal-facing access tags with each internal-facing access application.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        [NameInMap("UnauthorizedAccessConfig")]
        [Validation(Required=false)]
        public PAApplicationUnauthorizedAccessConfig UnauthorizedAccessConfig { get; set; }

    }

}
