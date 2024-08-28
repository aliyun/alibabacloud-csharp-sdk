// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class GetInstanceDetailResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceDetailResponseBodyData Data { get; set; }
        public class GetInstanceDetailResponseBodyData : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            [NameInMap("BucketPath")]
            [Validation(Required=false)]
            public string BucketPath { get; set; }

            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public GetInstanceDetailResponseBodyDataClusterInfo ClusterInfo { get; set; }
            public class GetInstanceDetailResponseBodyDataClusterInfo : TeaModel {
                [NameInMap("AttuPort")]
                [Validation(Required=false)]
                public int? AttuPort { get; set; }

                [NameInMap("InternetUrl")]
                [Validation(Required=false)]
                public string InternetUrl { get; set; }

                [NameInMap("IntranetUrl")]
                [Validation(Required=false)]
                public string IntranetUrl { get; set; }

                [NameInMap("MilvusResourceInfoList")]
                [Validation(Required=false)]
                public List<GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoList> MilvusResourceInfoList { get; set; }
                public class GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoList : TeaModel {
                    [NameInMap("ComponentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    [NameInMap("CuNum")]
                    [Validation(Required=false)]
                    public int? CuNum { get; set; }

                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public int? DiskSize { get; set; }

                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("Replica")]
                    [Validation(Required=false)]
                    public int? Replica { get; set; }

                }

                [NameInMap("OssStorageSize")]
                [Validation(Required=false)]
                public string OssStorageSize { get; set; }

                [NameInMap("OssStorageTimestamp")]
                [Validation(Required=false)]
                public long? OssStorageTimestamp { get; set; }

                [NameInMap("ProxyPort")]
                [Validation(Required=false)]
                public int? ProxyPort { get; set; }

                [NameInMap("TotalCuNum")]
                [Validation(Required=false)]
                public int? TotalCuNum { get; set; }

                [NameInMap("TotalDiskSize")]
                [Validation(Required=false)]
                public int? TotalDiskSize { get; set; }

            }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("MeasureConfig")]
            [Validation(Required=false)]
            public GetInstanceDetailResponseBodyDataMeasureConfig MeasureConfig { get; set; }
            public class GetInstanceDetailResponseBodyDataMeasureConfig : TeaModel {
                [NameInMap("DataNodeCuNum")]
                [Validation(Required=false)]
                public int? DataNodeCuNum { get; set; }

                [NameInMap("DataNodeReplica")]
                [Validation(Required=false)]
                public int? DataNodeReplica { get; set; }

                [NameInMap("IndexNodeCuNum")]
                [Validation(Required=false)]
                public int? IndexNodeCuNum { get; set; }

                [NameInMap("IndexNodeReplica")]
                [Validation(Required=false)]
                public int? IndexNodeReplica { get; set; }

                [NameInMap("MixCoodinatorNodeCuNum")]
                [Validation(Required=false)]
                public int? MixCoodinatorNodeCuNum { get; set; }

                [NameInMap("MixCoodinatorNodeReplica")]
                [Validation(Required=false)]
                public int? MixCoodinatorNodeReplica { get; set; }

                [NameInMap("ProxyNodeCuNum")]
                [Validation(Required=false)]
                public int? ProxyNodeCuNum { get; set; }

                [NameInMap("ProxyNodeReplica")]
                [Validation(Required=false)]
                public int? ProxyNodeReplica { get; set; }

                [NameInMap("QueryNodeCuNum")]
                [Validation(Required=false)]
                public int? QueryNodeCuNum { get; set; }

                [NameInMap("QueryNodeReplica")]
                [Validation(Required=false)]
                public int? QueryNodeReplica { get; set; }

            }

            [NameInMap("OpenPublicNet")]
            [Validation(Required=false)]
            public bool? OpenPublicNet { get; set; }

            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            [NameInMap("UserConfig")]
            [Validation(Required=false)]
            public string UserConfig { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
