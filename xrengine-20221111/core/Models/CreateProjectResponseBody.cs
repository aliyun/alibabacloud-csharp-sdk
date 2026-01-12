// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class CreateProjectResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateProjectResponseBodyData Data { get; set; }
        public class CreateProjectResponseBodyData : TeaModel {
            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Dataset")]
            [Validation(Required=false)]
            public CreateProjectResponseBodyDataDataset Dataset { get; set; }
            public class CreateProjectResponseBodyDataDataset : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public CreateProjectResponseBodyDataDatasetPolicy Policy { get; set; }
                public class CreateProjectResponseBodyDataDatasetPolicy : TeaModel {
                    [NameInMap("AccessId")]
                    [Validation(Required=false)]
                    public string AccessId { get; set; }

                    [NameInMap("Dir")]
                    [Validation(Required=false)]
                    public string Dir { get; set; }

                    [NameInMap("Expire")]
                    [Validation(Required=false)]
                    public string Expire { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Signature")]
                    [Validation(Required=false)]
                    public string Signature { get; set; }

                }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Intro")]
            [Validation(Required=false)]
            public string Intro { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public CreateProjectResponseBodyDataSource Source { get; set; }
            public class CreateProjectResponseBodyDataSource : TeaModel {
                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public CreateProjectResponseBodyDataSourcePolicy Policy { get; set; }
                public class CreateProjectResponseBodyDataSourcePolicy : TeaModel {
                    [NameInMap("AccessId")]
                    [Validation(Required=false)]
                    public string AccessId { get; set; }

                    [NameInMap("Dir")]
                    [Validation(Required=false)]
                    public string Dir { get; set; }

                    [NameInMap("Expire")]
                    [Validation(Required=false)]
                    public string Expire { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Signature")]
                    [Validation(Required=false)]
                    public string Signature { get; set; }

                }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
