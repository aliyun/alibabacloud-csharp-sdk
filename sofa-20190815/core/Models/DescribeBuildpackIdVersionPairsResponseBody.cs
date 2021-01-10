// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeBuildpackIdVersionPairsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

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

        [NameInMap("BuildpackCompositeVOs")]
        [Validation(Required=false)]
        public List<DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOs> BuildpackCompositeVOs { get; set; }
        public class DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOs : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Publisher")]
            [Validation(Required=false)]
            public DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsPublisher Publisher { get; set; }
            public class DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsPublisher : TeaModel {
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

            [NameInMap("FullVersion")]
            [Validation(Required=false)]
            public string FullVersion { get; set; }

            [NameInMap("OriginType")]
            [Validation(Required=false)]
            public string OriginType { get; set; }

            [NameInMap("Techstack")]
            [Validation(Required=false)]
            public DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsTechstack Techstack { get; set; }
            public class DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsTechstack : TeaModel {
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

            [NameInMap("SupportedOS")]
            [Validation(Required=false)]
            public List<DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsSupportedOS> SupportedOS { get; set; }
            public class DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsSupportedOS : TeaModel {
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

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("SupportedRegions")]
            [Validation(Required=false)]
            public List<DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsSupportedRegions> SupportedRegions { get; set; }
            public class DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsSupportedRegions : TeaModel {
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
                public DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsSupportedRegionsRegion Region { get; set; }
                public class DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsSupportedRegionsRegion : TeaModel {
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

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsCreator Creator { get; set; }
            public class DescribeBuildpackIdVersionPairsResponseBodyBuildpackCompositeVOsCreator : TeaModel {
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

        }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
