// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeMetadataResponseBody : TeaModel {
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public DescribeMetadataResponseBodyMetaData MetaData { get; set; }
        public class DescribeMetadataResponseBodyMetaData : TeaModel {
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            [NameInMap("ProEdition")]
            [Validation(Required=false)]
            public DescribeMetadataResponseBodyMetaDataProEdition ProEdition { get; set; }
            public class DescribeMetadataResponseBodyMetaDataProEdition : TeaModel {
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                [NameInMap("VersionCrds")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VersionCrds { get; set; }

                [NameInMap("VersionRegistry")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VersionRegistry { get; set; }

                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<string> Versions { get; set; }

            }

            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<string> Regions { get; set; }

            [NameInMap("VersionCrds")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> VersionCrds { get; set; }

            [NameInMap("VersionRegistry")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> VersionRegistry { get; set; }

            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
