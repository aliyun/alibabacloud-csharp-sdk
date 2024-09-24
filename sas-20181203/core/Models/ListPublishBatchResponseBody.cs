// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPublishBatchResponseBody : TeaModel {
        [NameInMap("BatchList")]
        [Validation(Required=false)]
        public List<ListPublishBatchResponseBodyBatchList> BatchList { get; set; }
        public class ListPublishBatchResponseBodyBatchList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1371</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("BatchInterval")]
            [Validation(Required=false)]
            public int? BatchInterval { get; set; }

            [NameInMap("BatchName")]
            [Validation(Required=false)]
            public string BatchName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2147483647</para>
            /// </summary>
            [NameInMap("BatchNo")]
            [Validation(Required=false)]
            public int? BatchNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("BatchProcess")]
            [Validation(Required=false)]
            public int? BatchProcess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BatchTotal")]
            [Validation(Required=false)]
            public int? BatchTotal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OperationBase")]
            [Validation(Required=false)]
            public int? OperationBase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListPublishBatchResponseBodyPageInfo PageInfo { get; set; }
        public class ListPublishBatchResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
