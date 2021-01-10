// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryTimeTemplateDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTimeTemplateDetailResponseBodyData Data { get; set; }
        public class QueryTimeTemplateDetailResponseBodyData : TeaModel {
            [NameInMap("TimeSectionList")]
            [Validation(Required=false)]
            public List<QueryTimeTemplateDetailResponseBodyDataTimeSectionList> TimeSectionList { get; set; }
            public class QueryTimeTemplateDetailResponseBodyDataTimeSectionList : TeaModel {
                public int? DayOfWeek { get; set; }
                public int? Begin { get; set; }
                public int? End { get; set; }
            }
            [NameInMap("AllDay")]
            [Validation(Required=false)]
            public int? AllDay { get; set; }
            [NameInMap("Default")]
            [Validation(Required=false)]
            public int? Default { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
