// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListServiceSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
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
        public List<ListServiceSourceResponseBodyData> Data { get; set; }
        public class ListServiceSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Container Service for Kubernetes (ACK) cluster or the endpoint of the Microservices Engine (MSE) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Indicates whether the service source is associated with the gateway. The value 1 indicates that the service source is associated with the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BindingWithGateway")]
            [Validation(Required=false)]
            public int? BindingWithGateway { get; set; }

            /// <summary>
            /// <para>The ID of the gateway.</para>
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
            /// <para>The information about the support for Ingresses by applications.</para>
            /// </summary>
            [NameInMap("IngressOptions")]
            [Validation(Required=false)]
            public ListServiceSourceResponseBodyDataIngressOptions IngressOptions { get; set; }
            public class ListServiceSourceResponseBodyDataIngressOptions : TeaModel {
                /// <summary>
                /// <para>Indicates whether Ingresses are enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableIngress")]
                [Validation(Required=false)]
                public bool? EnableIngress { get; set; }

                /// <summary>
                /// <para>Indicates whether the Ingress status is updated.</para>
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
                /// <para>The namespace that you want to monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("WatchNamespace")]
                [Validation(Required=false)]
                public string WatchNamespace { get; set; }

            }

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
            /// <para>The array of root paths of service lists.</para>
            /// </summary>
            [NameInMap("PathList")]
            [Validation(Required=false)]
            public List<string> PathList { get; set; }

            /// <summary>
            /// <para>The type of the service source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MSE</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The unique ID of the service source.</para>
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
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8C4B0D8-EBB9-5F20-8295-04224FBE5529</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
