// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAnalysisConditionFavoriteListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAnalysisConditionFavoriteListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAnalysisConditionFavoriteListResponseBodyResultObject : TeaModel {
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            [NameInMap("eventBeginTime")]
            [Validation(Required=false)]
            public long? EventBeginTime { get; set; }

            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public string EventCodes { get; set; }

            [NameInMap("eventEndTime")]
            [Validation(Required=false)]
            public long? EventEndTime { get; set; }

            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
