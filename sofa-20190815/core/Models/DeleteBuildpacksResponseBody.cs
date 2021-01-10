// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteBuildpacksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BuildpackDetailVo")]
        [Validation(Required=false)]
        public List<DeleteBuildpacksResponseBodyBuildpackDetailVo> BuildpackDetailVo { get; set; }
        public class DeleteBuildpacksResponseBodyBuildpackDetailVo : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("FullVersion")]
            [Validation(Required=false)]
            public string FullVersion { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("BuildpackParams")]
            [Validation(Required=false)]
            public List<DeleteBuildpacksResponseBodyBuildpackDetailVoBuildpackParams> BuildpackParams { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoBuildpackParams : TeaModel {
                [NameInMap("BuildpackId")]
                [Validation(Required=false)]
                public string BuildpackId { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Readonly")]
                [Validation(Required=false)]
                public bool? Readonly { get; set; }

            }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public DeleteBuildpacksResponseBodyBuildpackDetailVoCreator Creator { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoCreator : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
            };

            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public bool? DebugMode { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ContactInfo")]
            [Validation(Required=false)]
            public string ContactInfo { get; set; }

            [NameInMap("Techstack")]
            [Validation(Required=false)]
            public DeleteBuildpacksResponseBodyBuildpackDetailVoTechstack Techstack { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoTechstack : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public string ExtraInfo { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
            };

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("CreatedFrom")]
            [Validation(Required=false)]
            public string CreatedFrom { get; set; }

            [NameInMap("BuildCommand")]
            [Validation(Required=false)]
            public string BuildCommand { get; set; }

            [NameInMap("Publisher")]
            [Validation(Required=false)]
            public DeleteBuildpacksResponseBodyBuildpackDetailVoPublisher Publisher { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoPublisher : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
            };

            [NameInMap("PatchVersion")]
            [Validation(Required=false)]
            public long? PatchVersion { get; set; }

            [NameInMap("SupportedOS")]
            [Validation(Required=false)]
            public List<DeleteBuildpacksResponseBodyBuildpackDetailVoSupportedOS> SupportedOS { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoSupportedOS : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("FullName")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                [NameInMap("OsBit")]
                [Validation(Required=false)]
                public long? OsBit { get; set; }

                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public string ExtraInfo { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("OsBitNum")]
                [Validation(Required=false)]
                public long? OsBitNum { get; set; }

                [NameInMap("SupportedCloudDisplayNames")]
                [Validation(Required=false)]
                public List<string> SupportedCloudDisplayNames { get; set; }

                [NameInMap("SupportedCloudNames")]
                [Validation(Required=false)]
                public List<string> SupportedCloudNames { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("AppServiceCount")]
            [Validation(Required=false)]
            public long? AppServiceCount { get; set; }

            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public long? MinorVersion { get; set; }

            [NameInMap("CreationChain")]
            [Validation(Required=false)]
            public List<string> CreationChain { get; set; }

            [NameInMap("SupportedRegions")]
            [Validation(Required=false)]
            public List<DeleteBuildpacksResponseBodyBuildpackDetailVoSupportedRegions> SupportedRegions { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoSupportedRegions : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("FileChecksum")]
                [Validation(Required=false)]
                public string FileChecksum { get; set; }

                [NameInMap("BuildpackTenantId")]
                [Validation(Required=false)]
                public string BuildpackTenantId { get; set; }

                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                [NameInMap("OriginalFileName")]
                [Validation(Required=false)]
                public string OriginalFileName { get; set; }

                [NameInMap("BuildpackId")]
                [Validation(Required=false)]
                public string BuildpackId { get; set; }

                [NameInMap("FromRegionId")]
                [Validation(Required=false)]
                public string FromRegionId { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public DeleteBuildpacksResponseBodyBuildpackDetailVoSupportedRegionsRegion Region { get; set; }
                public class DeleteBuildpacksResponseBodyBuildpackDetailVoSupportedRegionsRegion : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }
                };

                [NameInMap("FileLocation")]
                [Validation(Required=false)]
                public string FileLocation { get; set; }

                [NameInMap("ReadableFileSize")]
                [Validation(Required=false)]
                public string ReadableFileSize { get; set; }

                [NameInMap("FileStatus")]
                [Validation(Required=false)]
                public string FileStatus { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

            }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("AvailableTenantNames")]
            [Validation(Required=false)]
            public List<string> AvailableTenantNames { get; set; }

            [NameInMap("OriginType")]
            [Validation(Required=false)]
            public string OriginType { get; set; }

            [NameInMap("StorageUploadEndpoints")]
            [Validation(Required=false)]
            public List<DeleteBuildpacksResponseBodyBuildpackDetailVoStorageUploadEndpoints> StorageUploadEndpoints { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoStorageUploadEndpoints : TeaModel {
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                [NameInMap("FilePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Expiration")]
                [Validation(Required=false)]
                public string Expiration { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("EncodedPolicy")]
                [Validation(Required=false)]
                public string EncodedPolicy { get; set; }

                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }

            [NameInMap("DepracationNote")]
            [Validation(Required=false)]
            public string DepracationNote { get; set; }

            [NameInMap("MajorVersion")]
            [Validation(Required=false)]
            public long? MajorVersion { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("PublicationTime")]
            [Validation(Required=false)]
            public string PublicationTime { get; set; }

            [NameInMap("BuildCommandParams")]
            [Validation(Required=false)]
            public List<DeleteBuildpacksResponseBodyBuildpackDetailVoBuildCommandParams> BuildCommandParams { get; set; }
            public class DeleteBuildpacksResponseBodyBuildpackDetailVoBuildCommandParams : TeaModel {
                [NameInMap("BuildpackId")]
                [Validation(Required=false)]
                public string BuildpackId { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            [NameInMap("IndustryLabel")]
            [Validation(Required=false)]
            public string IndustryLabel { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
