// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeCostCheckAdvicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCostCheckAdvicesResponseBodyData Data { get; set; }
        public class DescribeCostCheckAdvicesResponseBodyData : TeaModel {
            [NameInMap("AdviceList")]
            [Validation(Required=false)]
            public List<DescribeCostCheckAdvicesResponseBodyDataAdviceList> AdviceList { get; set; }
            public class DescribeCostCheckAdvicesResponseBodyDataAdviceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccountFolderId")]
                [Validation(Required=false)]
                public string AccountFolderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccountFolderName")]
                [Validation(Required=false)]
                public string AccountFolderName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111******767</para>
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public long? AliyunId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;Domains\&quot;: [{\&quot;Status\&quot;: \&quot;success\&quot;, \&quot;\&quot;: \&quot;cn\&quot;, \&quot;DomainName\&quot;: \&quot;www.****.com\&quot;, Region\&quot;Desc\&quot;: \&quot;ok\&quot;}]}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Email</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-05T02:02:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-05T02:02:00Z</para>
                /// </summary>
                [NameInMap("GmtDeleted")]
                [Validation(Required=false)]
                public long? GmtDeleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-2ze5*****ef7d2lk63in</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1200***bles_df</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-02-04T16:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeCostCheckAdvicesResponseBodyDataAdviceListTags> Tags { get; set; }
                public class DescribeCostCheckAdvicesResponseBodyDataAdviceListTags : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>autoTest-7</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>basic</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EcsHighCpuUtilization</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public string CheckId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>566331F9-****-550F-B745-A730331F97A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
