// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class DeleteMcuJobResponseBody : TeaModel {
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public DeleteMcuJobResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class DeleteMcuJobResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeletedJobIds")]
        [Validation(Required=false)]
        public DeleteMcuJobResponseBodyDeletedJobIds DeletedJobIds { get; set; }
        public class DeleteMcuJobResponseBodyDeletedJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
