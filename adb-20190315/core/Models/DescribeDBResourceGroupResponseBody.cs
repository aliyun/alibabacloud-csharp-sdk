// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried resource group.</para>
        /// </summary>
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            /// <summary>
            /// <para>The working mode of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Disable</b> (default)</description></item>
            /// <item><description><b>AutoScale</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoScale</para>
            /// </summary>
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            /// <summary>
            /// <para>The resource specifications of a single compute cluster. Unit: ACU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ClusterSizeResource")]
            [Validation(Required=false)]
            public string ClusterSizeResource { get; set; }

            /// <summary>
            /// <para>The endpoint of the resource group.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of Engine is SparkWarehouse.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>amv-bp1nw64y******.ads.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-09 16:57:35.241</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The minimum amount of elastic computing resources. Unit: ACU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ElasticMinComputeResource")]
            [Validation(Required=false)]
            public string ElasticMinComputeResource { get; set; }

            /// <summary>
            /// <para>The engine of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AnalyticDB</b> (default)</description></item>
            /// <item><description><b>SparkWarehouse</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The Spark application configuration parameters that can be applied to all Spark jobs executed in the resource group. If you want to configure parameters for a specific Spark job, you can specify values for the parameters in the code editor when you submit the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;spark.adb.version\&quot;:\&quot;3.5\&quot;}</para>
            /// </summary>
            [NameInMap("EngineParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> EngineParams { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DEFAULT</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The query execution mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>interactive</b> (default)</description></item>
            /// <item><description><b>batch</b></description></item>
            /// <item><description><b>job</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>interactive</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The database accounts that are associated with the resource group.</para>
            /// </summary>
            [NameInMap("GroupUserList")]
            [Validation(Required=false)]
            public List<string> GroupUserList { get; set; }

            /// <summary>
            /// <para>The database accounts that are associated with the resource group. Multiple database accounts are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testb,testc</para>
            /// </summary>
            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            /// <summary>
            /// <para>The maximum number of compute clusters that are allowed in the resource group. Maximum value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaxClusterCount")]
            [Validation(Required=false)]
            public int? MaxClusterCount { get; set; }

            /// <summary>
            /// <para>The maximum amount of reserved computing resources, which refers to the amount of resources that are not allocated in the cluster. Unit: ACU.</para>
            /// <list type="bullet">
            /// <item><description>If the value of GroupType is <b>interactive</b>, the amount of reserved computing resources that are not allocated in the cluster is returned in increments of 16ACU.</description></item>
            /// <item><description>If the value of GroupType is <b>job</b>, the amount of reserved computing resources that are not allocated in the cluster is returned in increments of 8ACU.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>32ACU</para>
            /// </summary>
            [NameInMap("MaxComputeResource")]
            [Validation(Required=false)]
            public string MaxComputeResource { get; set; }

            /// <summary>
            /// <para>The minimum number of compute clusters that are required in the resource group. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinClusterCount")]
            [Validation(Required=false)]
            public int? MinClusterCount { get; set; }

            /// <summary>
            /// <para>The minimum amount of reserved computing resources. Unit: AnalyticDB compute unit (ACU).</para>
            /// <list type="bullet">
            /// <item><description>If the value of GroupType is <b>interactive</b>, 16ACU is returned.</description></item>
            /// <item><description>If the value of GroupType is <b>job</b>, 0ACU is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0ACU</para>
            /// </summary>
            [NameInMap("MinComputeResource")]
            [Validation(Required=false)]
            public string MinComputeResource { get; set; }

            /// <summary>
            /// <para>The number of nodes. Each node provides 16 cores and 64 GB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// <para>The port number of the resource group.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of Engine is SparkWarehouse.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The number of compute clusters running in the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RunningClusterCount")]
            [Validation(Required=false)]
            public int? RunningClusterCount { get; set; }

            /// <summary>
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b></description></item>
            /// <item><description><b>Running</b></description></item>
            /// <item><description><b>Scaling</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the resource group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-09 16:57:35.241</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
