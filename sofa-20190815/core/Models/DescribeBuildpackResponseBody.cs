// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeBuildpackResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Buildpacks")]
        [Validation(Required=false)]
        public List<DescribeBuildpackResponseBodyBuildpacks> Buildpacks { get; set; }
        public class DescribeBuildpackResponseBodyBuildpacks : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("FullVersion")]
            [Validation(Required=false)]
            public string FullVersion { get; set; }

            [NameInMap("SupportedOs")]
            [Validation(Required=false)]
            public List<DescribeBuildpackResponseBodyBuildpacksSupportedOs> SupportedOs { get; set; }
            public class DescribeBuildpackResponseBodyBuildpacksSupportedOs : TeaModel {
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

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

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
            public DescribeBuildpackResponseBodyBuildpacksTechstack Techstack { get; set; }
            public class DescribeBuildpackResponseBodyBuildpacksTechstack : TeaModel {
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

            [NameInMap("TechstackId")]
            [Validation(Required=false)]
            public long? TechstackId { get; set; }

            [NameInMap("PublicationTimeDate")]
            [Validation(Required=false)]
            public string PublicationTimeDate { get; set; }

            [NameInMap("PatchVersion")]
            [Validation(Required=false)]
            public long? PatchVersion { get; set; }

            [NameInMap("AppServiceCount")]
            [Validation(Required=false)]
            public long? AppServiceCount { get; set; }

            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public long? MinorVersion { get; set; }

            [NameInMap("SupportedRegions")]
            [Validation(Required=false)]
            public List<string> SupportedRegions { get; set; }

            [NameInMap("CreationChain")]
            [Validation(Required=false)]
            public List<string> CreationChain { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("AvailableTenantNames")]
            [Validation(Required=false)]
            public List<string> AvailableTenantNames { get; set; }

            [NameInMap("OriginType")]
            [Validation(Required=false)]
            public string OriginType { get; set; }

            [NameInMap("SupportedRegionsList")]
            [Validation(Required=false)]
            public List<DescribeBuildpackResponseBodyBuildpacksSupportedRegionsList> SupportedRegionsList { get; set; }
            public class DescribeBuildpackResponseBodyBuildpacksSupportedRegionsList : TeaModel {
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
                public DescribeBuildpackResponseBodyBuildpacksSupportedRegionsListRegion Region { get; set; }
                public class DescribeBuildpackResponseBodyBuildpacksSupportedRegionsListRegion : TeaModel {
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }
                    [NameInMap("BuildpackTenantId")]
                    [Validation(Required=false)]
                    public string BuildpackTenantId { get; set; }
                    [NameInMap("FileChecksum")]
                    [Validation(Required=false)]
                    public string FileChecksum { get; set; }
                    [NameInMap("Identity")]
                    [Validation(Required=false)]
                    public string Identity { get; set; }
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }
                    [NameInMap("UtcCreate")]
                    [Validation(Required=false)]
                    public string UtcCreate { get; set; }
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }
                    [NameInMap("ModificationTime")]
                    [Validation(Required=false)]
                    public string ModificationTime { get; set; }
                    [NameInMap("ObjectName")]
                    [Validation(Required=false)]
                    public string ObjectName { get; set; }
                    [NameInMap("OriginalFileName")]
                    [Validation(Required=false)]
                    public string OriginalFileName { get; set; }
                    [NameInMap("BuildpackId")]
                    [Validation(Required=false)]
                    public string BuildpackId { get; set; }
                    [NameInMap("ZoneDtos")]
                    [Validation(Required=false)]
                    public string ZoneDtos { get; set; }
                    [NameInMap("FromRegionId")]
                    [Validation(Required=false)]
                    public string FromRegionId { get; set; }
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }
                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public string UtcModified { get; set; }
                    [NameInMap("IaasProviderId")]
                    [Validation(Required=false)]
                    public string IaasProviderId { get; set; }
                    [NameInMap("FileLocation")]
                    [Validation(Required=false)]
                    public string FileLocation { get; set; }
                    [NameInMap("ReadableFileSize")]
                    [Validation(Required=false)]
                    public string ReadableFileSize { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public long? FileSize { get; set; }
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

            [NameInMap("IndustryLabel")]
            [Validation(Required=false)]
            public string IndustryLabel { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
