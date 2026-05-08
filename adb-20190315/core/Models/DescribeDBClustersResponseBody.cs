// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyItems Items { get; set; }
        public class DescribeDBClustersResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyItemsDBCluster : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public string ComputeResource { get; set; }

                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                [NameInMap("DBClusterType")]
                [Validation(Required=false)]
                public string DBClusterType { get; set; }

                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                [NameInMap("DBNodeCount")]
                [Validation(Required=false)]
                public long? DBNodeCount { get; set; }

                [NameInMap("DBNodeStorage")]
                [Validation(Required=false)]
                public long? DBNodeStorage { get; set; }

                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("DtsJobId")]
                [Validation(Required=false)]
                public string DtsJobId { get; set; }

                [NameInMap("ElasticIOResource")]
                [Validation(Required=false)]
                public int? ElasticIOResource { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("ExecutorCount")]
                [Validation(Required=false)]
                public string ExecutorCount { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                [NameInMap("InnerPort")]
                [Validation(Required=false)]
                public string InnerPort { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("RdsInstanceId")]
                [Validation(Required=false)]
                public string RdsInstanceId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("StorageResource")]
                [Validation(Required=false)]
                public string StorageResource { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TaskInfo")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTaskInfo TaskInfo { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfo : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StepList")]
                    [Validation(Required=false)]
                    public DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepList StepList { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepList : TeaModel {
                        [NameInMap("StepList")]
                        [Validation(Required=false)]
                        public List<DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepListStepList> StepList { get; set; }
                        public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepListStepList : TeaModel {
                            [NameInMap("EndTime")]
                            [Validation(Required=false)]
                            public string EndTime { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("StepDesc")]
                            [Validation(Required=false)]
                            public string StepDesc { get; set; }

                            [NameInMap("StepName")]
                            [Validation(Required=false)]
                            public string StepName { get; set; }

                            [NameInMap("StepProgress")]
                            [Validation(Required=false)]
                            public string StepProgress { get; set; }

                            [NameInMap("StepStatus")]
                            [Validation(Required=false)]
                            public string StepStatus { get; set; }

                        }

                    }

                }

                [NameInMap("VPCCloudInstanceId")]
                [Validation(Required=false)]
                public string VPCCloudInstanceId { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
