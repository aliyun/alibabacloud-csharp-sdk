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
        /// <para>The list of SDG information.</para>
        /// </summary>
        [NameInMap("SDGs")]
        [Validation(Required=false)]
        public List<DescribeSDGsResponseBodySDGs> SDGs { get; set; }
        public class DescribeSDGsResponseBodySDGs : TeaModel {
            /// <summary>
            /// <para>The list of available edge zones.</para>
            /// </summary>
            [NameInMap("AvaliableRegionIds")]
            [Validation(Required=false)]
            public List<DescribeSDGsResponseBodySDGsAvaliableRegionIds> AvaliableRegionIds { get; set; }
            public class DescribeSDGsResponseBodySDGsAvaliableRegionIds : TeaModel {
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
                /// <para>mock-clone_snapshot_id</para>
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
            /// <para>Hour</para>
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
            /// <para>The instance ID of the instance used to create the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aic-5x20dyeos****</para>
            /// </summary>
            [NameInMap("CreationInstanceId")]
            [Validation(Required=false)]
            public string CreationInstanceId { get; set; }

            /// <summary>
            /// <para>The edge zone ID where the SDG was created.</para>
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
            /// <para>The list of deployment status information.</para>
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
                /// <para>The SDG deployment type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>common: standard deployment</description></item>
                /// <item><description>overlay: read/write splitting deployment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>overlay</para>
                /// </summary>
                [NameInMap("DeploymentType")]
                [Validation(Required=false)]
                public string DeploymentType { get; set; }

                /// <summary>
                /// <para>The AIC instance ID.</para>
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
                /// <item><description><b>sdg_deploying</b>: Being deployed.</description></item>
                /// <item><description><b>failed</b>: Deployment failed.</description></item>
                /// <item><description><b>success</b>: Deployment succeeded.</description></item>
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
            /// <para>Test SDG</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the source SDG used for incremental creation. This is the <b>FromSDGId</b> parameter passed when calling <a href="https://help.aliyun.com/document_detail/608128.html">CreateSDG</a>.</para>
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
            public long? PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The SDG ID.</para>
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

    }

}
