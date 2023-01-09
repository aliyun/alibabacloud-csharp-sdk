// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListEnvsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<ListEnvsResponseBodyEnvs> Envs { get; set; }
        public class ListEnvsResponseBodyEnvs : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }

            [NameInMap("EnvVersion")]
            [Validation(Required=false)]
            public string EnvVersion { get; set; }

            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListEnvsResponseBodyEnvsFiles> Files { get; set; }
            public class ListEnvsResponseBodyEnvsFiles : TeaModel {
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

            }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<ListEnvsResponseBodyEnvsProperties> Properties { get; set; }
            public class ListEnvsResponseBodyEnvsProperties : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("RelatedScenes")]
            [Validation(Required=false)]
            public List<string> RelatedScenes { get; set; }

            [NameInMap("RunningScenes")]
            [Validation(Required=false)]
            public List<string> RunningScenes { get; set; }

            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public long? UsedCapacity { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
