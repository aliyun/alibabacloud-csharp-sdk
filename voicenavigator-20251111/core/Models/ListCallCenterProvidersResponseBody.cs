// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListCallCenterProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The call center provider data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallCenterProvidersResponseBodyData Data { get; set; }
        public class ListCallCenterProvidersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>A list of call center providers.</para>
            /// </summary>
            [NameInMap("Providers")]
            [Validation(Required=false)]
            public List<ListCallCenterProvidersResponseBodyDataProviders> Providers { get; set; }
            public class ListCallCenterProvidersResponseBodyDataProviders : TeaModel {
                /// <summary>
                /// <para>The destination of the call transfer. Required if the transfer mode is <c>Bridge</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>153*********</para>
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                /// <summary>
                /// <para>The display name of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云联络中心内部服务提供商</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The extra data.&gt;Notice:  Format: <c>k1=v1;k2=v2</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>key1=value1</para>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public string Extras { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The service provider name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云联络中心内部服务提供商</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The originator of the call transfer. Required if the transfer mode is <c>Bridge</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>010****</para>
                /// </summary>
                [NameInMap("Originator")]
                [Validation(Required=false)]
                public string Originator { get; set; }

                /// <summary>
                /// <para>The call center provider ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxxxxx</para>
                /// </summary>
                [NameInMap("ProviderId")]
                [Validation(Required=false)]
                public string ProviderId { get; set; }

                /// <summary>
                /// <para>The provider type.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para><c>CCC</c>: Cloud Contact Center</para>
                /// </description></item>
                /// <item><description><para><c>CUSTOM</c>: customer-owned contact center</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>CCC</para>
                /// </summary>
                [NameInMap("ProviderType")]
                [Validation(Required=false)]
                public string ProviderType { get; set; }

                /// <summary>
                /// <para>The Refer address.&gt;Notice:  Required if the transfer mode is <c>Refer</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ReferTo")]
                [Validation(Required=false)]
                public string ReferTo { get; set; }

                /// <summary>
                /// <para>The trunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trunk-xxx</para>
                /// </summary>
                [NameInMap("TrunkId")]
                [Validation(Required=false)]
                public string TrunkId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75BAAB9B-40B2-5FF5-A59A-7BCF8154C6EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
