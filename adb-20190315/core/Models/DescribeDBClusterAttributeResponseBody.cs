// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAttributeResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClusterAttributeResponseBodyItemsDBCluster : TeaModel {
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

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

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

                [NameInMap("DiskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                [NameInMap("DiskPerformanceLevel")]
                [Validation(Required=false)]
                public string DiskPerformanceLevel { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("DtsJobId")]
                [Validation(Required=false)]
                public string DtsJobId { get; set; }

                [NameInMap("ElasticIOResource")]
                [Validation(Required=false)]
                public int? ElasticIOResource { get; set; }

                [NameInMap("ElasticIOResourceSize")]
                [Validation(Required=false)]
                public string ElasticIOResourceSize { get; set; }

                [NameInMap("EnableAirflow")]
                [Validation(Required=false)]
                public bool? EnableAirflow { get; set; }

                [NameInMap("EnableSpark")]
                [Validation(Required=false)]
                public bool? EnableSpark { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

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

                [NameInMap("KmsId")]
                [Validation(Required=false)]
                public string KmsId { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("MaintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("ProductForm")]
                [Validation(Required=false)]
                public string ProductForm { get; set; }

                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("RdsInstanceId")]
                [Validation(Required=false)]
                public string RdsInstanceId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReservedNodeCount")]
                [Validation(Required=false)]
                public int? ReservedNodeCount { get; set; }

                [NameInMap("ReservedNodeSize")]
                [Validation(Required=false)]
                public string ReservedNodeSize { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecondaryVSwitchId")]
                [Validation(Required=false)]
                public string SecondaryVSwitchId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                [NameInMap("StorageResource")]
                [Validation(Required=false)]
                public string StorageResource { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClusterAttributeResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClusterAttributeResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTagsTag : TeaModel {
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
                public DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfo TaskInfo { get; set; }
                public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfo : TeaModel {
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
                    public DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepList StepList { get; set; }
                    public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepList : TeaModel {
                        [NameInMap("StepList")]
                        [Validation(Required=false)]
                        public List<DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepListStepList> StepList { get; set; }
                        public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepListStepList : TeaModel {
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

                [NameInMap("UserENIStatus")]
                [Validation(Required=false)]
                public bool? UserENIStatus { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2895BB82-B2C1-408E-AA73-DB8D59******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
