// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationConfigResponseBodyData Data { get; set; }
        public class DescribeApplicationConfigResponseBodyData : TeaModel {
            [NameInMap("AcrAssumeRoleArn")]
            [Validation(Required=false)]
            public string AcrAssumeRoleArn { get; set; }
            [NameInMap("AcrInstanceId")]
            [Validation(Required=false)]
            public string AcrInstanceId { get; set; }
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AssociateEip")]
            [Validation(Required=false)]
            public bool? AssociateEip { get; set; }
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }
            [NameInMap("ConfigMapMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataConfigMapMountDesc> ConfigMapMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataConfigMapMountDesc : TeaModel {
                public long? ConfigMapId { get; set; }
                public string ConfigMapName { get; set; }
                public string Key { get; set; }
                public string MountPath { get; set; }
            }
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }
            [NameInMap("CustomHostAlias")]
            [Validation(Required=false)]
            public string CustomHostAlias { get; set; }
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }
            [NameInMap("EnableAhas")]
            [Validation(Required=false)]
            public string EnableAhas { get; set; }
            [NameInMap("EnableGreyTagRoute")]
            [Validation(Required=false)]
            public bool? EnableGreyTagRoute { get; set; }
            [NameInMap("Envs")]
            [Validation(Required=false)]
            public string Envs { get; set; }
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }
            [NameInMap("JarStartArgs")]
            [Validation(Required=false)]
            public string JarStartArgs { get; set; }
            [NameInMap("JarStartOptions")]
            [Validation(Required=false)]
            public string JarStartOptions { get; set; }
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }
            [NameInMap("KafkaConfigs")]
            [Validation(Required=false)]
            public string KafkaConfigs { get; set; }
            [NameInMap("Liveness")]
            [Validation(Required=false)]
            public string Liveness { get; set; }
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }
            [NameInMap("MinReadyInstanceRatio")]
            [Validation(Required=false)]
            public int? MinReadyInstanceRatio { get; set; }
            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataMountDesc : TeaModel {
                public string MountPath { get; set; }
                public string NasPath { get; set; }
            }
            [NameInMap("MountHost")]
            [Validation(Required=false)]
            public string MountHost { get; set; }
            [NameInMap("MseApplicationId")]
            [Validation(Required=false)]
            public string MseApplicationId { get; set; }
            [NameInMap("MseFeatureConfig")]
            [Validation(Required=false)]
            public string MseFeatureConfig { get; set; }
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }
            [NameInMap("NasId")]
            [Validation(Required=false)]
            public string NasId { get; set; }
            [NameInMap("OssAkId")]
            [Validation(Required=false)]
            public string OssAkId { get; set; }
            [NameInMap("OssAkSecret")]
            [Validation(Required=false)]
            public string OssAkSecret { get; set; }
            [NameInMap("OssMountDescs")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataOssMountDescs> OssMountDescs { get; set; }
            public class DescribeApplicationConfigResponseBodyDataOssMountDescs : TeaModel {
                public string BucketName { get; set; }
                public string BucketPath { get; set; }
                public string MountPath { get; set; }
                public bool? ReadOnly { get; set; }
            }
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }
            [NameInMap("PhpArmsConfigLocation")]
            [Validation(Required=false)]
            public string PhpArmsConfigLocation { get; set; }
            [NameInMap("PhpConfig")]
            [Validation(Required=false)]
            public string PhpConfig { get; set; }
            [NameInMap("PhpConfigLocation")]
            [Validation(Required=false)]
            public string PhpConfigLocation { get; set; }
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }
            [NameInMap("Readiness")]
            [Validation(Required=false)]
            public string Readiness { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataTags> Tags { get; set; }
            public class DescribeApplicationConfigResponseBodyDataTags : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("TerminationGracePeriodSeconds")]
            [Validation(Required=false)]
            public int? TerminationGracePeriodSeconds { get; set; }
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }
            [NameInMap("TomcatConfig")]
            [Validation(Required=false)]
            public string TomcatConfig { get; set; }
            [NameInMap("UpdateStrategy")]
            [Validation(Required=false)]
            public string UpdateStrategy { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("WarStartOptions")]
            [Validation(Required=false)]
            public string WarStartOptions { get; set; }
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
