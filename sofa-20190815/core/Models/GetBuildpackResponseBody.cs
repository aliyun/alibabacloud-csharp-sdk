// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetBuildpackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("BuildpackDetailVO")]
        [Validation(Required=false)]
        public GetBuildpackResponseBodyBuildpackDetailVO BuildpackDetailVO { get; set; }
        public class GetBuildpackResponseBodyBuildpackDetailVO : TeaModel {
            [NameInMap("AppServiceCount")]
            [Validation(Required=false)]
            public long? AppServiceCount { get; set; }
            [NameInMap("BuildCommand")]
            [Validation(Required=false)]
            public string BuildCommand { get; set; }
            [NameInMap("ContactInfo")]
            [Validation(Required=false)]
            public string ContactInfo { get; set; }
            [NameInMap("CreatedFrom")]
            [Validation(Required=false)]
            public string CreatedFrom { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public bool? DebugMode { get; set; }
            [NameInMap("DepracationNote")]
            [Validation(Required=false)]
            public string DepracationNote { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }
            [NameInMap("FullVersion")]
            [Validation(Required=false)]
            public string FullVersion { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IndustryLabel")]
            [Validation(Required=false)]
            public string IndustryLabel { get; set; }
            [NameInMap("MajorVersion")]
            [Validation(Required=false)]
            public long? MajorVersion { get; set; }
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public long? MinorVersion { get; set; }
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }
            [NameInMap("OriginType")]
            [Validation(Required=false)]
            public string OriginType { get; set; }
            [NameInMap("PatchVersion")]
            [Validation(Required=false)]
            public long? PatchVersion { get; set; }
            [NameInMap("PublicationTime")]
            [Validation(Required=false)]
            public string PublicationTime { get; set; }
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("AvailableTenantNames")]
            [Validation(Required=false)]
            public List<string> AvailableTenantNames { get; set; }
            [NameInMap("CreationChain")]
            [Validation(Required=false)]
            public List<string> CreationChain { get; set; }
            [NameInMap("BuildpackParams")]
            [Validation(Required=false)]
            public List<GetBuildpackResponseBodyBuildpackDetailVOBuildpackParams> BuildpackParams { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOBuildpackParams : TeaModel {
                public string BuildpackId { get; set; }
                public string DefaultValue { get; set; }
                public string Description { get; set; }
                public string Id { get; set; }
                public string Key { get; set; }
                public bool? Readonly { get; set; }
                public bool? Required { get; set; }
            }
            [NameInMap("BuildCommandParams")]
            [Validation(Required=false)]
            public List<GetBuildpackResponseBodyBuildpackDetailVOBuildCommandParams> BuildCommandParams { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOBuildCommandParams : TeaModel {
                public string BuildpackId { get; set; }
                public string Description { get; set; }
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("StorageUploadEndpoints")]
            [Validation(Required=false)]
            public List<GetBuildpackResponseBodyBuildpackDetailVOStorageUploadEndpoints> StorageUploadEndpoints { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOStorageUploadEndpoints : TeaModel {
                public string AccessKeyId { get; set; }
                public string Bucket { get; set; }
                public string EncodedPolicy { get; set; }
                public string Expiration { get; set; }
                public string FilePath { get; set; }
                public string Host { get; set; }
                public string RegionId { get; set; }
                public string Signature { get; set; }
                public string StorageType { get; set; }
                public string Url { get; set; }
            }
            [NameInMap("SupportedOS")]
            [Validation(Required=false)]
            public List<GetBuildpackResponseBodyBuildpackDetailVOSupportedOS> SupportedOS { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOSupportedOS : TeaModel {
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string ExtraInfo { get; set; }
                public string FullName { get; set; }
                public long? Id { get; set; }
                public string ModificationTime { get; set; }
                public string Name { get; set; }
                public long? OsBit { get; set; }
                public long? OsBitNum { get; set; }
                public string Version { get; set; }
                public List<string> SupportedCloudDisplayNames { get; set; }
                public List<string> SupportedCloudNames { get; set; }
            }
            [NameInMap("SupportedRegions")]
            [Validation(Required=false)]
            public List<GetBuildpackResponseBodyBuildpackDetailVOSupportedRegions> SupportedRegions { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOSupportedRegions : TeaModel {
                public string BuildpackId { get; set; }
                public string BuildpackTenantId { get; set; }
                public string CreationTime { get; set; }
                public string FileChecksum { get; set; }
                public string FileLocation { get; set; }
                public long? FileSize { get; set; }
                public string FileStatus { get; set; }
                public string FromRegionId { get; set; }
                public string Id { get; set; }
                public string ModificationTime { get; set; }
                public string ObjectName { get; set; }
                public string OriginalFileName { get; set; }
                public string ReadableFileSize { get; set; }
                public GetBuildpackResponseBodyBuildpackDetailVOSupportedRegionsRegion Region { get; set; }
                public class GetBuildpackResponseBodyBuildpackDetailVOSupportedRegionsRegion : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }
            }
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetBuildpackResponseBodyBuildpackDetailVOCreator Creator { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOCreator : TeaModel {
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }
            [NameInMap("Publisher")]
            [Validation(Required=false)]
            public GetBuildpackResponseBodyBuildpackDetailVOPublisher Publisher { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOPublisher : TeaModel {
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }
            [NameInMap("Techstack")]
            [Validation(Required=false)]
            public GetBuildpackResponseBodyBuildpackDetailVOTechstack Techstack { get; set; }
            public class GetBuildpackResponseBodyBuildpackDetailVOTechstack : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public string ExtraInfo { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }
        };

    }

}
