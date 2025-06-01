// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The addresses of the office applications. You can enter up to 1,000 addresses of office applications.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>The ID of the office application. You can obtain the value by calling the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: queries office applications.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: creates an office application.</description></item>
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
        /// <para>The description of the office application. The value must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter. The parameter specifies the configurations of Layer 7 applications.</para>
        /// </summary>
        [NameInMap("L7Config")]
        [Validation(Required=false)]
        public string L7ConfigShrink { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter. The parameter specifies the prefix of the domain name that the proxy gateway uses. The prefix must be 3 to 20 characters in length, and can contain lowercase letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1-xxx</para>
        /// </summary>
        [NameInMap("L7ProxyDomainAutomaticPrefix")]
        [Validation(Required=false)]
        public string L7ProxyDomainAutomaticPrefix { get; set; }

        /// <summary>
        /// <para>The browser access mode parameter. The parameter specifies the custom domain name of the proxy gateway.</para>
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
        /// <para>浏览器访问模式参数：私有代理域名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1.example.com</para>
        /// </summary>
        [NameInMap("L7ProxyDomainPrivate")]
        [Validation(Required=false)]
        [Obsolete]
        public string L7ProxyDomainPrivate { get; set; }

        /// <summary>
        /// <para>The modification type of the office application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: uses the values of the <b>Addresses</b>, <b>PortRanges</b>, and <b>TagIds</b> parameters to overwrite the original addresses, port ranges, and tag IDs. This is the default value.</description></item>
        /// <item><description><b>Append</b>: adds the values of the <b>Addresses</b>, <b>PortRanges</b>, and <b>TagIds</b> parameters respectively to the original addresses, port ranges, and tag IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The port ranges of the office applications. You can enter up to 65,535 port ranges. Multiple port ranges cannot be duplicated or overlapped.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessApplicationShrinkRequestPortRanges> PortRanges { get; set; }
        public class UpdatePrivateAccessApplicationShrinkRequestPortRanges : TeaModel {
            /// <summary>
            /// <para>The start port. The start port must be less than or equal to the end port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <para>The end port. The end port must be greater than or equal to the start port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

        /// <summary>
        /// <para>The protocol that is used by the office application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b></description></item>
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
        /// <para>The status of the office application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IDs of the tags for the office applications. You can add up to six custom tags to an office application.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
