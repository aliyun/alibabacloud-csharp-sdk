// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsForSwimmingLaneResponseBody : TeaModel {
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
        /// <para>The list of applications.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListApplicationsForSwimmingLaneResponseBodyData> Data { get; set; }
        public class ListApplicationsForSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the baseline application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8c573618-8d72-4407-baf4-f7b64b******</para>
            /// </summary>
            [NameInMap("BaseAppId")]
            [Validation(Required=false)]
            public string BaseAppId { get; set; }

            /// <summary>
            /// <para>The name of the baseline application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("BaseAppName")]
            [Validation(Required=false)]
            public string BaseAppName { get; set; }

            /// <summary>
            /// <para>The ID of the MSE instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-hvm47******</para>
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
            /// <para>sae-test</para>
            /// </summary>
            [NameInMap("MseNamespaceId")]
            [Validation(Required=false)]
            public string MseNamespaceId { get; set; }

            /// <summary>
            /// <para>The canary tag configured for the application.</para>
            /// </summary>
            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public Dictionary<string, string> ServiceTags { get; set; }

        }

        /// <summary>
        /// <para>The status code. Value values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, the <b>ErrorCode</b> parameter is returned. For more information, see <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned. The following limits are imposed on the ID:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>success</b> is returned.</description></item>
        /// <item><description>An error code is returned when a request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the trace. The ID is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the list of application instances was queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance groups were obtained.</description></item>
        /// <item><description><b>false</b>: The instance groups failed to be obtained.</description></item>
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
