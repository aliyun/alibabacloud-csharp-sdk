// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewaySlbResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewaySlbResponseBodyData> Data { get; set; }
        public class ListGatewaySlbResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the resource is editable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EditEnable")]
            [Validation(Required=false)]
            public bool? EditEnable { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserSelect</para>
            /// </summary>
            [NameInMap("GatewaySlbMode")]
            [Validation(Required=false)]
            public string GatewaySlbMode { get; set; }

            /// <summary>
            /// <para>The association status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("GatewaySlbStatus")]
            [Validation(Required=false)]
            public string GatewaySlbStatus { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-14 14:39:16</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The HTTP port (virtual server group).</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            /// <summary>
            /// <para>The HTTPS port (virtual server group).</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("HttpsPort")]
            [Validation(Required=false)]
            public int? HttpsPort { get; set; }

            /// <summary>
            /// <para>The ID of the HTTPS virtual server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>353</para>
            /// </summary>
            [NameInMap("HttpsVServerGroupId")]
            [Validation(Required=false)]
            public string HttpsVServerGroupId { get; set; }

            /// <summary>
            /// <para>ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The service weight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ServiceWeight")]
            [Validation(Required=false)]
            public int? ServiceWeight { get; set; }

            /// <summary>
            /// <para>SLB ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1kmnli3hdpreptw2ah3</para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>SLB IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.199.XX.XX</para>
            /// </summary>
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            /// <summary>
            /// <para>The SLB port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,443</para>
            /// </summary>
            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public string SlbPort { get; set; }

            /// <summary>
            /// <para>The SLB type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLB</para>
            /// </summary>
            [NameInMap("SlbType")]
            [Validation(Required=false)]
            public string SlbType { get; set; }

            /// <summary>
            /// <para>The status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Associating</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUB_NET: Internet.</description></item>
            /// <item><description>PRIVATE_NET: Private network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUB_NET</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the HTTP virtual server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>353</para>
            /// </summary>
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

            /// <summary>
            /// <para>The SLB listener information.</para>
            /// </summary>
            [NameInMap("VServiceList")]
            [Validation(Required=false)]
            public List<ListGatewaySlbResponseBodyDataVServiceList> VServiceList { get; set; }
            public class ListGatewaySlbResponseBodyDataVServiceList : TeaModel {
                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HTTPS</description></item>
                /// <item><description>HTTP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTPS</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The ID of the virtual server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-bp183l2x70***</para>
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                /// <summary>
                /// <para>The name of the virtual server group.</para>
                /// </summary>
                [NameInMap("VServerGroupName")]
                [Validation(Required=false)]
                public string VServerGroupName { get; set; }

            }

            /// <summary>
            /// <para>The metadata of the virtual server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;protocol&quot;:&quot;HTTP&quot;,&quot;vServerGroupName&quot;:&quot;k8s/80/<em><em><b>&quot;,&quot;port&quot;:80,&quot;vServerGroupId&quot;:&quot;rsp-bp</b></em>&quot;},{&quot;protocol&quot;:&quot;HTTPS&quot;,&quot;vServerGroupName&quot;:&quot;k8s/443/</em><b>&quot;,&quot;port&quot;:443,&quot;vServerGroupId&quot;:&quot;rsp-bp</b>***&quot;}]</para>
            /// </summary>
            [NameInMap("VsMetaInfo")]
            [Validation(Required=false)]
            public string VsMetaInfo { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succ</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAB345F4-3AC3-560C-B653-65717703****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
