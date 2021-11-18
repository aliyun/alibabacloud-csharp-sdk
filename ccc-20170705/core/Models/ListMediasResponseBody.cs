// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListMediasResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Medias")]
        [Validation(Required=false)]
        public ListMediasResponseBodyMedias Medias { get; set; }
        public class ListMediasResponseBodyMedias : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListMediasResponseBodyMediasList List { get; set; }
            public class ListMediasResponseBodyMediasList : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public List<ListMediasResponseBodyMediasListMedia> Media { get; set; }
                public class ListMediasResponseBodyMediasListMedia : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FilePath")]
                    [Validation(Required=false)]
                    public string FilePath { get; set; }

                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public string Instance { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OssFileName")]
                    [Validation(Required=false)]
                    public string OssFileName { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

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
