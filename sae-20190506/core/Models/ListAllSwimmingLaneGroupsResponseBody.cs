// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAllSwimmingLaneGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or the error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: The request was redirected.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Responses.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAllSwimmingLaneGroupsResponseBodyData> Data { get; set; }
        public class ListAllSwimmingLaneGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The IDs of the applications associated with the lane group.</para>
            /// </summary>
            [NameInMap("AppIds")]
            [Validation(Required=false)]
            public List<string> AppIds { get; set; }

            /// <summary>
            /// <para>The application information.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAllSwimmingLaneGroupsResponseBodyDataApps> Apps { get; set; }
            public class ListAllSwimmingLaneGroupsResponseBodyDataApps : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f5aad0d0-3e56-44cd-8199-9887a0******</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The ID of the MSE instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse-cn-53y49******</para>
                /// </summary>
                [NameInMap("MseAppId")]
                [Validation(Required=false)]
                public string MseAppId { get; set; }

                /// <summary>
                /// <para>The name of the MSE instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("MseAppName")]
                [Validation(Required=false)]
                public string MseAppName { get; set; }

                /// <summary>
                /// <para>The ID of the namespace to which the MSE instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6733e538-d52f-48e6-91a4-192f91******</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>Full-link Grayscale Mode:</para>
            /// <list type="bullet">
            /// <item><description>0: The request is routed based on the content of the request.</description></item>
            /// <item><description>1: Proportional routing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            /// <summary>
            /// <para>The entry application.</para>
            /// </summary>
            [NameInMap("EntryApp")]
            [Validation(Required=false)]
            public ListAllSwimmingLaneGroupsResponseBodyDataEntryApp EntryApp { get; set; }
            public class ListAllSwimmingLaneGroupsResponseBodyDataEntryApp : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09805e5d-9b8d-42cd-9442-03c498******</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The type of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The ID of the MSE instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse-cn-53y49******</para>
                /// </summary>
                [NameInMap("MseAppId")]
                [Validation(Required=false)]
                public string MseAppId { get; set; }

                /// <summary>
                /// <para>MSE Instance Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("MseAppName")]
                [Validation(Required=false)]
                public string MseAppName { get; set; }

                /// <summary>
                /// <para>The ID of the namespace to which the MSE instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse_ingresspost-cn-axc49******</para>
            /// </summary>
            [NameInMap("EntryAppId")]
            [Validation(Required=false)]
            public string EntryAppId { get; set; }

            /// <summary>
            /// <para>The application entry type (gateway type).</para>
            /// <list type="bullet">
            /// <item><description><b>apig:</b> cloud-native API Gateway</description></item>
            /// <item><description><b>mse-gw:</b> an MSE cloud original gateway</description></item>
            /// <item><description><b>mse:</b> Java Services Gateway</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mse-gw</para>
            /// </summary>
            [NameInMap("EntryAppType")]
            [Validation(Required=false)]
            public string EntryAppType { get; set; }

            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2074</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The name of a lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The ID of the namespace to which the MSE instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sae-test</para>
            /// </summary>
            [NameInMap("MseNamespaceId")]
            [Validation(Required=false)]
            public string MseNamespaceId { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The end-to-end grayscale version. Valid values: 0 and 2 (recommended).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SwimVersion")]
            [Validation(Required=false)]
            public string SwimVersion { get; set; }

        }

        /// <summary>
        /// <para>The status code. Value values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, <b>ErrorCode</b> is returned. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The error message returned because the request is normal and <b>success</b> is returned.</description></item>
        /// <item><description>If the request is abnormal, the specific exception error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30375C38-F4ED-4135-A0AE-5C75DC7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information was queried.</description></item>
        /// <item><description><b>false</b>: The information failed to be queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. This parameter is used to query the exact call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
