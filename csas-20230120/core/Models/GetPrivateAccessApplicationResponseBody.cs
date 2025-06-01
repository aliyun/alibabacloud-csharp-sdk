// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPrivateAccessApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The office application.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetPrivateAccessApplicationResponseBodyApplication Application { get; set; }
        public class GetPrivateAccessApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The addresses of the office applications.</para>
            /// </summary>
            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The ID of the office application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-application-e12860ef6c48****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The browser access mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b></description></item>
            /// <item><description><b>Disabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("BrowserAccessStatus")]
            [Validation(Required=false)]
            public string BrowserAccessStatus { get; set; }

            /// <summary>
            /// <para>The IDs of connectors.</para>
            /// </summary>
            [NameInMap("ConnectorIds")]
            [Validation(Required=false)]
            public List<string> ConnectorIds { get; set; }

            /// <summary>
            /// <para>The creation time of the office application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-30 16:50:32</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the office application.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The browser access mode parameter. The parameter indicates the configurations of Layer 7 applications.</para>
            /// </summary>
            [NameInMap("L7Config")]
            [Validation(Required=false)]
            public PAL7Config L7Config { get; set; }

            /// <summary>
            /// <para>The browser access mode parameter. The parameter indicates the domain name that the proxy gateway uses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.example.com</para>
            /// </summary>
            [NameInMap("L7ProxyDomainAutomatic")]
            [Validation(Required=false)]
            public string L7ProxyDomainAutomatic { get; set; }

            /// <summary>
            /// <para>The browser access mode parameter. The parameter indicates the custom domain name of the proxy gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.example.com</para>
            /// </summary>
            [NameInMap("L7ProxyDomainCustom")]
            [Validation(Required=false)]
            public string L7ProxyDomainCustom { get; set; }

            /// <summary>
            /// <para>The name of the office application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private_access_application_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of the private access policies.</para>
            /// </summary>
            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            /// <summary>
            /// <para>The port ranges of the office applications. Multiple port ranges cannot be duplicated or overlapped.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<GetPrivateAccessApplicationResponseBodyApplicationPortRanges> PortRanges { get; set; }
            public class GetPrivateAccessApplicationResponseBodyApplicationPortRanges : TeaModel {
                /// <summary>
                /// <para>The start port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public int? Begin { get; set; }

                /// <summary>
                /// <para>The end port.</para>
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
            /// <para>The IDs of the tags for the office applications.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ACC5EDC-2B7D-5032-8C58-D7615D66C1D4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
