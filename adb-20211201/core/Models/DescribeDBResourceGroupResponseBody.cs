// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried resource groups.</para>
        /// </summary>
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("ClusterSizeResource")]
            [Validation(Required=false)]
            public string ClusterSizeResource { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-29T03:34:30Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The minimum amount of elastic computing resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ElasticMinComputeResource")]
            [Validation(Required=false)]
            public string ElasticMinComputeResource { get; set; }

            /// <summary>
            /// <para>Indicates whether the preemptible instance feature is enabled for the resource group. After the preemptible instance feature is enabled, you are charged for resources at a lower unit price but the resources are probably released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>True</b></description></item>
            /// <item><description><b>False</b></description></item>
            /// </list>
            /// <para>The True value is returned only for job resource groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("EnableSpot")]
            [Validation(Required=false)]
            public string EnableSpot { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> EngineParams { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Interactive</b></description></item>
            /// <item><description><b>Job</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource groups</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Job</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The Resource Access Management (RAM) user that is associated with the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testb,testc</para>
            /// </summary>
            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("MaxClusterCount")]
            [Validation(Required=false)]
            public int? MaxClusterCount { get; set; }

            /// <summary>
            /// <para>The maximum amount of reserved computing resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512ACU</para>
            /// </summary>
            [NameInMap("MaxComputeResource")]
            [Validation(Required=false)]
            public string MaxComputeResource { get; set; }

            [NameInMap("MaxGpuQuantity")]
            [Validation(Required=false)]
            public int? MaxGpuQuantity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("MinClusterCount")]
            [Validation(Required=false)]
            public int? MinClusterCount { get; set; }

            /// <summary>
            /// <para>The minimum amount of reserved computing resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ACU</para>
            /// </summary>
            [NameInMap("MinComputeResource")]
            [Validation(Required=false)]
            public string MinComputeResource { get; set; }

            [NameInMap("MinGpuQuantity")]
            [Validation(Required=false)]
            public int? MinGpuQuantity { get; set; }

            /// <summary>
            /// <para>The job resubmission rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeDBResourceGroupResponseBodyGroupsInfoRules> Rules { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoRules : TeaModel {
                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_default</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The execution duration of the query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public string QueryTime { get; set; }

                /// <summary>
                /// <para>The name of the destination resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job</para>
                /// </summary>
                [NameInMap("TargetGroupName")]
                [Validation(Required=false)]
                public string TargetGroupName { get; set; }

            }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("RunningClusterCount")]
            [Validation(Required=false)]
            public int? RunningClusterCount { get; set; }

            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            /// <summary>
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>creating</b>: The resource group is being created.</description></item>
            /// <item><description><b>ok</b>: The resource group is created.</description></item>
            /// <item><description><b>pendingdelete</b>: The resource group is pending to be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TargetResourceGroupName")]
            [Validation(Required=false)]
            public string TargetResourceGroupName { get; set; }

            /// <summary>
            /// <para>The time when the resource group was updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31T03:34:30Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A94B6C02-7BD4-5D67-9776-3AC8317E8DD3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
