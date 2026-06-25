// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAllSwimmingLaneGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request was invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAllSwimmingLaneGroupsResponseBodyData> Data { get; set; }
        public class ListAllSwimmingLaneGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The IDs of the applications that are associated with the swimming lane group.</para>
            /// </summary>
            [NameInMap("AppIds")]
            [Validation(Required=false)]
            public List<string> AppIds { get; set; }

            /// <summary>
            /// <para>The information about the applications.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAllSwimmingLaneGroupsResponseBodyDataApps> Apps { get; set; }
            public class ListAllSwimmingLaneGroupsResponseBodyDataApps : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f5aad0d0-3e56-44cd-8199-9887a0******</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
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
                /// <para>sae-ent</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>The canary release mode.</para>
            /// <list type="bullet">
            /// <item><description><para>0: content-based routing</para>
            /// </description></item>
            /// <item><description><para>1: percentage-based routing</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            /// <summary>
            /// <para>The ingress application.</para>
            /// </summary>
            [NameInMap("EntryApp")]
            [Validation(Required=false)]
            public ListAllSwimmingLaneGroupsResponseBodyDataEntryApp EntryApp { get; set; }
            public class ListAllSwimmingLaneGroupsResponseBodyDataEntryApp : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09805e5d-9b8d-42cd-9442-03c498******</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The application type.</para>
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
                /// <para>The name of the MSE instance.</para>
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
                /// <para>sae-ent</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bq4g5bumop@e05bd4328******</para>
            /// </summary>
            [NameInMap("EntryAppId")]
            [Validation(Required=false)]
            public string EntryAppId { get; set; }

            /// <summary>
            /// <para>The type of the ingress application. This parameter is equivalent to the gateway type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>apig:</b> API Gateway</para>
            /// </description></item>
            /// <item><description><para><b>mse-gw:</b> cloud-native gateway</para>
            /// </description></item>
            /// <item><description><para><b>mse:</b> Java service gateway</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mse-gw</para>
            /// </summary>
            [NameInMap("EntryAppType")]
            [Validation(Required=false)]
            public string EntryAppType { get; set; }

            /// <summary>
            /// <para>The ID of the swimming lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110283</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the swimming lane group.</para>
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
            /// <para>sae-ent</para>
            /// </summary>
            [NameInMap("MseNamespaceId")]
            [Validation(Required=false)]
            public string MseNamespaceId { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The version of the canary release. Valid values: 0 and 2. We recommend that you use 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SwimVersion")]
            [Validation(Required=false)]
            public string SwimVersion { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>For a list of error codes, see the &quot;<b>Error codes</b>&quot; section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b> is returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>An error message is returned if the request fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30375C38-F4ED-4135-A0AE-5C75DC7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
