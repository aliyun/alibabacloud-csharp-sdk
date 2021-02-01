// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListMarkerResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMarkerResponseBodyData Data { get; set; }
        public class ListMarkerResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListMarkerResponseBodyDataList> List { get; set; }
            public class ListMarkerResponseBodyDataList : TeaModel {
                public string Id { get; set; }
                public string AlgorithmId { get; set; }
                public string UserId { get; set; }
                public string LabelId { get; set; }
                public string LabelName { get; set; }
                public string SampleId { get; set; }
                public string Content { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
            }
        };

    }

}
