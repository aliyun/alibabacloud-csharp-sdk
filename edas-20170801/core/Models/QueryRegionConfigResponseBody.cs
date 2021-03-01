// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryRegionConfigResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionConfig")]
        [Validation(Required=false)]
        public QueryRegionConfigResponseBodyRegionConfig RegionConfig { get; set; }
        public class QueryRegionConfigResponseBodyRegionConfig : TeaModel {
            [NameInMap("No")]
            [Validation(Required=false)]
            public int? No { get; set; }
            [NameInMap("FileServerConfig")]
            [Validation(Required=false)]
            public QueryRegionConfigResponseBodyRegionConfigFileServerConfig FileServerConfig { get; set; }
            public class QueryRegionConfigResponseBodyRegionConfigFileServerConfig : TeaModel {
                [NameInMap("InternalUrl")]
                [Validation(Required=false)]
                public string InternalUrl { get; set; }

                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

                [NameInMap("VpcUrl")]
                [Validation(Required=false)]
                public string VpcUrl { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }
            [NameInMap("AddressServerHost")]
            [Validation(Required=false)]
            public string AddressServerHost { get; set; }
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }
            [NameInMap("AgentInstallScript")]
            [Validation(Required=false)]
            public string AgentInstallScript { get; set; }
            [NameInMap("FileServerType")]
            [Validation(Required=false)]
            public string FileServerType { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
