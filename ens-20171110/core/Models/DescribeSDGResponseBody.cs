// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3B261DD-3858-4D3C-877D-303ADF374600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of SDG information.</para>
        /// </summary>
        [NameInMap("SDGs")]
        [Validation(Required=false)]
        public List<DescribeSDGResponseBodySDGs> SDGs { get; set; }
        public class DescribeSDGResponseBodySDGs : TeaModel {
            /// <summary>
            /// <para>The list of edge zones where SDG snapshots exist.</para>
            /// </summary>
            [NameInMap("AvaliableRegionIds")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsAvaliableRegionIds> AvaliableRegionIds { get; set; }
            public class DescribeSDGResponseBodySDGsAvaliableRegionIds : TeaModel {
                /// <summary>
                /// <para>The creation time of the SDG in the edge zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-27 15:13:26</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The edge zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-26</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The snapshot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-517qu0tgznrg622he7nf4wd7n</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// <para>The status of the SDG in the edge zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>sdg_making</b>: Being created.</description></item>
                /// <item><description><b>sdg_saving</b>: Being saved.</description></item>
                /// <item><description><b>sdg_copying</b>: Being synchronized across edge zones.</description></item>
                /// <item><description><b>failed</b>: Creation failed.</description></item>
                /// <item><description><b>success</b>: Creation succeeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The billing cycle of the shared disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Day</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The billing type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("BillingType")]
            [Validation(Required=false)]
            public string BillingType { get; set; }

            /// <summary>
            /// <para>The disk type of the source disk used to create the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("CreationDiskType")]
            [Validation(Required=false)]
            public string CreationDiskType { get; set; }

            /// <summary>
            /// <para>The instance ID of the instance from which the SDG was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aic-5x20dyeos****</para>
            /// </summary>
            [NameInMap("CreationInstanceId")]
            [Validation(Required=false)]
            public string CreationInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the edge zone where the SDG was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-26</para>
            /// </summary>
            [NameInMap("CreationRegionId")]
            [Validation(Required=false)]
            public string CreationRegionId { get; set; }

            /// <summary>
            /// <para>The time when the SDG was first created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-27 15:07:21</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test SDG</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the source SDG for incremental creation. This is the FromSDGId parameter specified when you called <a href="https://help.aliyun.com/document_detail/608128.html">CreateSDG</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdg-xxxxx</para>
            /// </summary>
            [NameInMap("ParentSDGId")]
            [Validation(Required=false)]
            public string ParentSDGId { get; set; }

            /// <summary>
            /// <para>The sharing ratio of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The preload configuration information.</para>
            /// </summary>
            [NameInMap("PreloadInfos")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsPreloadInfos> PreloadInfos { get; set; }
            public class DescribeSDGResponseBodySDGsPreloadInfos : TeaModel {
                /// <summary>
                /// <para>The creation time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-16T06:18:40Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The disk type of the redundant shared disks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-20000</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The number of redundant copies for fast shared mounting response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RedundantNum")]
                [Validation(Required=false)]
                public int? RedundantNum { get; set; }

                /// <summary>
                /// <para>The edge zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The most recent status update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-22T08:17Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdg-30e1fdba7196bc****</para>
            /// </summary>
            [NameInMap("SDGId")]
            [Validation(Required=false)]
            public string SDGId { get; set; }

            /// <summary>
            /// <para>The size of the SDG. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The creation status of the SDG. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sdg_making</b>: Being created.</description></item>
            /// <item><description><b>sdg_saving</b>: Being saved.</description></item>
            /// <item><description><b>failed</b>: Creation failed.</description></item>
            /// <item><description><b>success</b>: Creation succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the SDG was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-27 16:04:39</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
