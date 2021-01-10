// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeBuildpackOSByCurrentCloudResponseBody : TeaModel {
        [NameInMap("BuildpackOs")]
        [Validation(Required=false)]
        public List<DescribeBuildpackOSByCurrentCloudResponseBodyBuildpackOs> BuildpackOs { get; set; }
        public class DescribeBuildpackOSByCurrentCloudResponseBodyBuildpackOs : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
