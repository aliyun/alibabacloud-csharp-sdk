// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ListExperimentMetasResponseBody : TeaModel {
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public int? Pages { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<ListExperimentMetasResponseBodyContent> Content { get; set; }
        public class ListExperimentMetasResponseBodyContent : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
