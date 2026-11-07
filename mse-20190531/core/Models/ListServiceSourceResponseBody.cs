// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListServiceSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServiceSourceResponseBodyData> Data { get; set; }
        public class ListServiceSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ACK ID or the MSE registry address.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Indicates whether the binding is completed. A value of 1 indicates that the binding is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BindingWithGateway")]
            [Validation(Required=false)]
            public int? BindingWithGateway { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-2u9uhd9283hd92hgd39g239dg2*****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The array of service groups.</para>
            /// </summary>
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<string> GroupList { get; set; }

            /// <summary>
            /// <para>The ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The Ingress support for application routing.</para>
            /// </summary>
            [NameInMap("IngressOptions")]
            [Validation(Required=false)]
            public ListServiceSourceResponseBodyDataIngressOptions IngressOptions { get; set; }
            public class ListServiceSourceResponseBodyDataIngressOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable or disable Ingress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableIngress")]
                [Validation(Required=false)]
                public bool? EnableIngress { get; set; }

                /// <summary>
                /// <para>Specifies whether to update IngressStatus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public bool? EnableStatus { get; set; }

                /// <summary>
                /// <para>The Ingress class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.test.xxx</para>
                /// </summary>
                [NameInMap("IngressClass")]
                [Validation(Required=false)]
                public string IngressClass { get; set; }

                /// <summary>
                /// <para>The monitored namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("WatchNamespace")]
                [Validation(Required=false)]
                public string WatchNamespace { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the source is valid.</para>
            /// </summary>
            [NameInMap("Invalid")]
            [Validation(Required=false)]
            public bool? Invalid { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The array of root paths for the service list.</para>
            /// </summary>
            [NameInMap("PathList")]
            [Validation(Required=false)]
            public List<string> PathList { get; set; }

            /// <summary>
            /// <para>The source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MSE</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The unique identifier of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-***</para>
            /// </summary>
            [NameInMap("SourceUniqueId")]
            [Validation(Required=false)]
            public string SourceUniqueId { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NACOS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8C4B0D8-EBB9-5F20-8295-04224FBE5529</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
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
