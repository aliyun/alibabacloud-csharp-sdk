// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListClassificationsResponseBody : TeaModel {
        [NameInMap("Classifications")]
        [Validation(Required=false)]
        public ListClassificationsResponseBodyClassifications Classifications { get; set; }
        public class ListClassificationsResponseBodyClassifications : TeaModel {
            [NameInMap("Classification")]
            [Validation(Required=false)]
            public List<ListClassificationsResponseBodyClassificationsClassification> Classification { get; set; }
            public class ListClassificationsResponseBodyClassificationsClassification : TeaModel {
                [NameInMap("ClassificationCode")]
                [Validation(Required=false)]
                public string ClassificationCode { get; set; }

                [NameInMap("ClassificationName")]
                [Validation(Required=false)]
                public string ClassificationName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("OfficialCode")]
                [Validation(Required=false)]
                public string OfficialCode { get; set; }

                [NameInMap("ParentCode")]
                [Validation(Required=false)]
                public string ParentCode { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
