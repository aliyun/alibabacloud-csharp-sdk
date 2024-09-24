// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterResourceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The queried resource usage.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeClusterResourceDetailResponseBodyData Data { get; set; }
        public class DescribeClusterResourceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The amount of reserved computing resources. Unit: AnalyticDB compute units (ACUs). Valid values: 0 to 4096. The value must be in increments of 16 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ComputeResource")]
            [Validation(Required=false)]
            public string ComputeResource { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-adbxxxxx</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The amount of idle reserved computing resources. Unit: ACUs. Valid values: 0 to 4096. The value must be in increments of 16 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ACU</para>
            /// </summary>
            [NameInMap("FreeComputeResource")]
            [Validation(Required=false)]
            public string FreeComputeResource { get; set; }

            /// <summary>
            /// <para>The resource groups.</para>
            /// </summary>
            [NameInMap("ResourceGroupList")]
            [Validation(Required=false)]
            public List<DescribeClusterResourceDetailResponseBodyDataResourceGroupList> ResourceGroupList { get; set; }
            public class DescribeClusterResourceDetailResponseBodyDataResourceGroupList : TeaModel {
                /// <summary>
                /// <para>A reserved parameter.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ClusterMode")]
                [Validation(Required=false)]
                public string ClusterMode { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ClusterSizeResource")]
                [Validation(Required=false)]
                public string ClusterSizeResource { get; set; }

                /// <summary>
                /// <para>Indicates whether the preemptible instance feature is enabled for the resource group. After the preemptible instance feature is enabled, you are charged for resources at a lower unit price but the resources are probably released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <para>The True value is returned only for job resource groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableSpot")]
                [Validation(Required=false)]
                public bool? EnableSpot { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxClusterCount")]
                [Validation(Required=false)]
                public int? MaxClusterCount { get; set; }

                /// <summary>
                /// <para>The maximum amount of reserved computing resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128ACU</para>
                /// </summary>
                [NameInMap("MaxComputeResource")]
                [Validation(Required=false)]
                public string MaxComputeResource { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinClusterCount")]
                [Validation(Required=false)]
                public int? MinClusterCount { get; set; }

                /// <summary>
                /// <para>The minimum amount of reserved computing resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16ACU</para>
                /// </summary>
                [NameInMap("MinComputeResource")]
                [Validation(Required=false)]
                public string MinComputeResource { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("PoolId")]
                [Validation(Required=false)]
                public long? PoolId { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testadb</para>
                /// </summary>
                [NameInMap("PoolName")]
                [Validation(Required=false)]
                public string PoolName { get; set; }

                /// <summary>
                /// <para>The type of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>interactive</para>
                /// </summary>
                [NameInMap("PoolType")]
                [Validation(Required=false)]
                public string PoolType { get; set; }

                /// <summary>
                /// <para>The user of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("PoolUsers")]
                [Validation(Required=false)]
                public string PoolUsers { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RunningClusterCount")]
                [Validation(Required=false)]
                public int? RunningClusterCount { get; set; }

                /// <summary>
                /// <para>The status of the resource group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>running</b></description></item>
                /// <item><description><b>deleting</b></description></item>
                /// <item><description><b>scaling</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The amount of reserved storage resources. Unit: ACUs. Valid values: 0 to 2064. The value must be in increments of 24 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24ACU</para>
            /// </summary>
            [NameInMap("StorageResource")]
            [Validation(Required=false)]
            public string StorageResource { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
