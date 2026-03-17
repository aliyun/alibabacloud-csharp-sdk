// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ViewSmartAccessGatewayDnsForwardsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1914</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>A DNS forwarding list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayDnsForwardsResponseBodyData> Data { get; set; }
        public class ViewSmartAccessGatewayDnsForwardsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.baidu.com">www.baidu.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sagv3dnsforward-nc7qabskj17werc7su</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The primary DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.58.20</para>
            /// </summary>
            [NameInMap("MasterIp")]
            [Validation(Required=false)]
            public string MasterIp { get; set; }

            /// <summary>
            /// <para>The forwarding mode.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is not in use. Ignore this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>first</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The number of the egress port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OutboundPortIndex")]
            [Validation(Required=false)]
            public int? OutboundPortIndex { get; set; }

            /// <summary>
            /// <para>The egress port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eth0</para>
            /// </summary>
            [NameInMap("OutboundPortName")]
            [Validation(Required=false)]
            public string OutboundPortName { get; set; }

            /// <summary>
            /// <para>The type of the egress port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PhysicalPort</para>
            /// </summary>
            [NameInMap("OutboundPortType")]
            [Validation(Required=false)]
            public string OutboundPortType { get; set; }

            /// <summary>
            /// <para>The secondary DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.14</para>
            /// </summary>
            [NameInMap("SlaveIp")]
            [Validation(Required=false)]
            public string SlaveIp { get; set; }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E223E535-AE11-4158-B00F-DC107887A909</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
