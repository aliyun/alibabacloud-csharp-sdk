// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPublishBatchResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the batch release tasks.</para>
        /// </summary>
        [NameInMap("BatchList")]
        [Validation(Required=false)]
        public List<ListPublishBatchResponseBodyBatchList> BatchList { get; set; }
        public class ListPublishBatchResponseBodyBatchList : TeaModel {
            /// <summary>
            /// <para>The ID of the release batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1371</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <para>The interval between the completion of the current batch and the start of the next batch. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("BatchInterval")]
            [Validation(Required=false)]
            public int? BatchInterval { get; set; }

            /// <summary>
            /// <para>The name of the release batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>发布批次1</para>
            /// </summary>
            [NameInMap("BatchName")]
            [Validation(Required=false)]
            public string BatchName { get; set; }

            /// <summary>
            /// <para>The number of the current batch in a phased release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2147483647</para>
            /// </summary>
            [NameInMap("BatchNo")]
            [Validation(Required=false)]
            public int? BatchNo { get; set; }

            /// <summary>
            /// <para>The release progress of the current batch, indicating the number of machines that have been released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("BatchProcess")]
            [Validation(Required=false)]
            public int? BatchProcess { get; set; }

            /// <summary>
            /// <para>The total number of batches in the release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BatchTotal")]
            [Validation(Required=false)]
            public int? BatchTotal { get; set; }

            /// <summary>
            /// <para>The dimension for asset selection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: machine instance</description></item>
            /// <item><description><b>1</b>: machine group</description></item>
            /// <item><description><b>2</b>: VPC-connected instance ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OperationBase")]
            [Validation(Required=false)]
            public int? OperationBase { get; set; }

            /// <summary>
            /// <para>The release status of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not started</description></item>
            /// <item><description><b>1</b>: releasing</description></item>
            /// <item><description><b>2</b>: release completed</description></item>
            /// <item><description><b>3</b>: release paused</description></item>
            /// <item><description><b>4</b>: force upgrading.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The target version to upgrade to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListPublishBatchResponseBodyPageInfo PageInfo { get; set; }
        public class ListPublishBatchResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page when paging is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page when paging is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. The China Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
