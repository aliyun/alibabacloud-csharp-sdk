// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryTimeTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTimeTemplateResponseBodyData Data { get; set; }
        public class QueryTimeTemplateResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryTimeTemplateResponseBodyDataList> List { get; set; }
            public class QueryTimeTemplateResponseBodyDataList : TeaModel {
                public List<QueryTimeTemplateResponseBodyDataListTimeSectionList> TimeSectionList { get; set; }
                public class QueryTimeTemplateResponseBodyDataListTimeSectionList : TeaModel {
                    public int? DayOfWeek { get; set; }
                    public int? Begin { get; set; }
                    public int? End { get; set; }
                }
                public int? AllDay { get; set; }
                public int? Default { get; set; }
                public string Name { get; set; }
                public string TemplateId { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }
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
