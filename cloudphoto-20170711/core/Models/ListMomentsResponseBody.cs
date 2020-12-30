// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListMomentsResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Moments")]
        [Validation(Required=false)]
        public List<ListMomentsResponseBodyMoments> Moments { get; set; }
        public class ListMomentsResponseBodyMoments : TeaModel {
            [NameInMap("IdStr")]
            [Validation(Required=false)]
            public string IdStr { get; set; }

            [NameInMap("PhotosCount")]
            [Validation(Required=false)]
            public int? PhotosCount { get; set; }

            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public long? Mtime { get; set; }

            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public long? Ctime { get; set; }

            [NameInMap("TakenAt")]
            [Validation(Required=false)]
            public long? TakenAt { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
