// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3703C4AC-9396-458C-8F25-1D701334D309</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the SDGs.</para>
        /// </summary>
        [NameInMap("SDGs")]
        [Validation(Required=false)]
        public List<DescribeSDGsResponseBodySDGs> SDGs { get; set; }
        public class DescribeSDGsResponseBodySDGs : TeaModel {
            /// <summary>
            /// <para>The IDs of available edge nodes.</para>
            /// </summary>
            [NameInMap("AvaliableRegionIds")]
            [Validation(Required=false)]
            public List<DescribeSDGsResponseBodySDGsAvaliableRegionIds> AvaliableRegionIds { get; set; }
            public class DescribeSDGsResponseBodySDGsAvaliableRegionIds : TeaModel {
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
                /// <para>The ID of the edge node.</para>
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
                /// <para>mock-clone_snapshot_id</para>
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
            /// <para>The time when the SDG was first created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-27 15:07:21</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The deployment information.</para>
            /// </summary>
            [NameInMap("DeployedInstanceIds")]
            [Validation(Required=false)]
            public List<DescribeSDGsResponseBodySDGsDeployedInstanceIds> DeployedInstanceIds { get; set; }
            public class DescribeSDGsResponseBodySDGsDeployedInstanceIds : TeaModel {
                /// <summary>
                /// <para>The time when the SDG was deployed on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-27 16:48:43</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The deployment type of the SDG. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>common: common deployment.</description></item>
                /// <item><description>overlay: read/write splitting deployment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>overlay</para>
                /// </summary>
                [NameInMap("DeploymentType")]
                [Validation(Required=false)]
                public string DeploymentType { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aic-5x20dyeos****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The deployment status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>sdg_deploying</b></description></item>
                /// <item><description><b>failed</b></description></item>
                /// <item><description><b>success</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sdg_deploying</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public long? PerformanceLevel { get; set; }

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

    }

}
