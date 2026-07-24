// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCreditDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCreditDetailResponseBodyData Data { get; set; }
        public class DescribeCreditDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The credit change details.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeCreditDetailResponseBodyDataDetails> Details { get; set; }
            public class DescribeCreditDetailResponseBodyDataDetails : TeaModel {
                [NameInMap("ApiKeyName")]
                [Validation(Required=false)]
                public string ApiKeyName { get; set; }

                [NameInMap("CachedTokens")]
                [Validation(Required=false)]
                public long? CachedTokens { get; set; }

                /// <summary>
                /// <para>The time when the change occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-30T08:14:02Z</para>
                /// </summary>
                [NameInMap("ChangeTime")]
                [Validation(Required=false)]
                public string ChangeTime { get; set; }

                /// <summary>
                /// <para>The credit change amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7637</para>
                /// </summary>
                [NameInMap("CreditChange")]
                [Validation(Required=false)]
                public string CreditChange { get; set; }

                /// <summary>
                /// <para>The task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Open Xiaohongshu.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acp-12oe0l75vl7o5****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The ID of the credit or plan package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmag-0c1g77wjljl9h****</para>
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The task ID, which is globally unique.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-1fr0k51pozyr5****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of detail records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The total credit change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCreditChange")]
            [Validation(Required=false)]
            public string TotalCreditChange { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
