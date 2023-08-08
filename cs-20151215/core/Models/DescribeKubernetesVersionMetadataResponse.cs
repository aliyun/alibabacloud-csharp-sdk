// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeKubernetesVersionMetadataResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeKubernetesVersionMetadataResponseBody> Body { get; set; }
        public class DescribeKubernetesVersionMetadataResponseBody : TeaModel {
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public Dictionary<string, object> Capabilities { get; set; }

            [NameInMap("images")]
            [Validation(Required=false)]
            public List<DescribeKubernetesVersionMetadataResponseBodyImages> Images { get; set; }
            public class DescribeKubernetesVersionMetadataResponseBodyImages : TeaModel {
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("image_name")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("os_version")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                [NameInMap("image_type")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                [NameInMap("os_type")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                [NameInMap("image_category")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                [NameInMap("architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

            }

            [NameInMap("meta_data")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

            [NameInMap("runtimes")]
            [Validation(Required=false)]
            public List<Runtime> Runtimes { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("release_date")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

            [NameInMap("expiration_date")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            [NameInMap("creatable")]
            [Validation(Required=false)]
            public bool? Creatable { get; set; }

        }

    }

}
