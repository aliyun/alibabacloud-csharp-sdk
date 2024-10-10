// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespaceChangeOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
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
                /// <para>The number of release batches.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                /// <summary>
                /// <para>The mode in which the release batches are determined. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>auto</b>: SAE automatically determines the release batches.</description></item>
                /// <item><description><b>manual</b>: You must manually determine the release batches.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// <para>The ID of the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7fa5c0-9ebb-4bb4-b383-1f885447****</para>
                /// </summary>
                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// <para>The type of the change order, which corresponds the <b>CoTypeCode</b> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msg.docker.app.actions.CoBatchStartApplication</para>
                /// </summary>
                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                /// <summary>
                /// <para>The code of the change order type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CoBatchStartApplication</b>: starts multiple applications concurrently.</description></item>
                /// <item><description><b>CoBatchStopApplication</b>: stops multiple applications concurrently.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CoBatchStartApplication</para>
                /// </summary>
                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                /// <summary>
                /// <para>The time when the change order was created.</para>
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
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the change order was completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-11 20:12:58</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c9ecd2-cf6c-46c3-9f20-525de202****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai:test</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The information about release batches.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Pipelines")]
                [Validation(Required=false)]
                public string Pipelines { get; set; }

                /// <summary>
                /// <para>The source of the change order.</para>
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
                /// <item><description><b>0</b>: The change order is being prepared.</description></item>
                /// <item><description><b>1</b>: The change order is being executed.</description></item>
                /// <item><description><b>2</b>: The change order was executed.</description></item>
                /// <item><description><b>3</b>: The change order could not be executed.</description></item>
                /// <item><description><b>6</b>: The change order was terminated.</description></item>
                /// <item><description><b>10</b>: The change order could not be executed due to a system exception.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_sae</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
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
        /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
        /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>0bc3915638507554994370d****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the list of change orders was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the list was obtained.</description></item>
        /// <item><description><b>false</b>: indicates that the list could not be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3915638507554994370d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
