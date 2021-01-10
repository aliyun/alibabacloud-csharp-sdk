// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotDBResponseBody : TeaModel {
        [NameInMap("FpShotDBList")]
        [Validation(Required=false)]
        public ListFpShotDBResponseBodyFpShotDBList FpShotDBList { get; set; }
        public class ListFpShotDBResponseBodyFpShotDBList : TeaModel {
            [NameInMap("FpShotDB")]
            [Validation(Required=false)]
            public List<ListFpShotDBResponseBodyFpShotDBListFpShotDB> FpShotDB { get; set; }
            public class ListFpShotDBResponseBodyFpShotDBListFpShotDB : TeaModel {
                public string Status { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public int? ModelId { get; set; }
                public string FpDBId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public ListFpShotDBResponseBodyNonExistIds NonExistIds { get; set; }
        public class ListFpShotDBResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
