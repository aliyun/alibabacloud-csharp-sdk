// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpCompareJobListResponseBody : TeaModel {
        [NameInMap("FpCompareJobList")]
        [Validation(Required=false)]
        public QueryFpCompareJobListResponseBodyFpCompareJobList FpCompareJobList { get; set; }
        public class QueryFpCompareJobListResponseBodyFpCompareJobList : TeaModel {
            [NameInMap("FpCompareJob")]
            [Validation(Required=false)]
            public List<QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJob> FpCompareJob { get; set; }
            public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJob : TeaModel {
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpCompareJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpCompareJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
