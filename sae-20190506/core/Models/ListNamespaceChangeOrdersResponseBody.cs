// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespaceChangeOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or POP error code.</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client error occurred.</para>
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
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespaceChangeOrdersResponseBodyData Data { get; set; }
        public class ListNamespaceChangeOrdersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of change orders.</para>
            /// </summary>
            [NameInMap("ChangeOrderList")]
            [Validation(Required=false)]
            public List<ListNamespaceChangeOrdersResponseBodyDataChangeOrderList> ChangeOrderList { get; set; }
            public class ListNamespaceChangeOrdersResponseBodyDataChangeOrderList : TeaModel {
                /// <summary>
                /// <para>The batch count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                /// <summary>
                /// <para>The batch type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Automatic</para>
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// <para>The change order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7fa5c0-9ebb-4bb4-b383-1f885447****</para>
                /// </summary>
                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// <para>The type of the change order, which corresponds to the <c>CoTypeCode</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msg.docker.app.actions.CoBatchStartApplication</para>
                /// </summary>
                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                /// <summary>
                /// <para>The type code of the change order. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>CoBatchStartApplication</b>: Starts applications in batches.</para>
                /// </description></item>
                /// <item><description><para><b>CoBatchStopApplication</b>: Stops applications in batches.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CoBatchStartApplication</para>
                /// </summary>
                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                /// <summary>
                /// <para>The creation time of the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-11 15:54:49</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// <para>The description of the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Batch Start Applications</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The completion time of the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-11 20:12:58</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c9ecd2-cf6c-46c3-9f20-525de202****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai:test</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The pipeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Pipelines")]
                [Validation(Required=false)]
                public string Pipelines { get; set; }

                /// <summary>
                /// <para>The initiation source for the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The status of the change order. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Preparing</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: In progress</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Succeeded</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Failed</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: Terminated</para>
                /// </description></item>
                /// <item><description><para><b>10</b>: Failed due to a system exception</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_sae</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of change orders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only when a request fails.</para>
        /// </description></item>
        /// <item><description><para>For more information, see the <b>Error codes</b> section of this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3915638507554994370d****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
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
        /// <para>The trace ID, which is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3915638507554994370d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
