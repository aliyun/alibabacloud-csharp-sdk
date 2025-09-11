// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The information about the SDGs.</para>
        /// </summary>
        [NameInMap("SDGs")]
        [Validation(Required=false)]
        public List<DescribeSDGResponseBodySDGs> SDGs { get; set; }
        public class DescribeSDGResponseBodySDGs : TeaModel {
            /// <summary>
            /// <para>SDGs that have snapshots.</para>
            /// </summary>
            [NameInMap("AvaliableRegionIds")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsAvaliableRegionIds> AvaliableRegionIds { get; set; }
            public class DescribeSDGResponseBodySDGsAvaliableRegionIds : TeaModel {
                /// <summary>
                /// <para>The time when the SDG was created on the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-27 15:13:26</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-26</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-517qu0tgznrg622he7nf4wd7n</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// <para>The status of the SDG on the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>sdg_making</b></description></item>
                /// <item><description><b>sdg_saving</b></description></item>
                /// <item><description><b>sdg_copying</b></description></item>
                /// <item><description><b>failed</b></description></item>
                /// <item><description><b>success</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            [NameInMap("CreationDiskType")]
            [Validation(Required=false)]
            public string CreationDiskType { get; set; }

            /// <summary>
            /// <para>The ID of the instance on which the SDG is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aic-5x20dyeos****</para>
            /// </summary>
            [NameInMap("CreationInstanceId")]
            [Validation(Required=false)]
            public string CreationInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the node on which the SDG is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-26</para>
            /// </summary>
            [NameInMap("CreationRegionId")]
            [Validation(Required=false)]
            public string CreationRegionId { get; set; }

            /// <summary>
            /// <para>The time when the first SDG in the node was created.</para>
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
            /// <para>Testing SDGs</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the source SDG from which you want to create an SDG. The value of this parameter is the value of the <b>FromSDGId</b> parameter that you need to specify when you call the <a href="https://help.aliyun.com/document_detail/608128.html">CreateSDG</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdg-xxxxx</para>
            /// </summary>
            [NameInMap("ParentSDGId")]
            [Validation(Required=false)]
            public string ParentSDGId { get; set; }

            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The preload information.</para>
            /// </summary>
            [NameInMap("PreloadInfos")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsPreloadInfos> PreloadInfos { get; set; }
            public class DescribeSDGResponseBodySDGsPreloadInfos : TeaModel {
                /// <summary>
                /// <para>The time when the SDG was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-16T06:18:40Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

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
                /// <para>The number of redundant replicas to quickly respond to shared mounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RedundantNum")]
                [Validation(Required=false)]
                public int? RedundantNum { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the status was last updated.</para>
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
            /// <para>The status of the SDG creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sdg_making</b></description></item>
            /// <item><description><b>sdg_saving</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// <item><description><b>success</b></description></item>
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
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
