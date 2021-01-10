// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryEventRecordPlanDeviceByDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEventRecordPlanDeviceByDeviceResponseBodyData Data { get; set; }
        public class QueryEventRecordPlanDeviceByDeviceResponseBodyData : TeaModel {
            [NameInMap("RecordDuration")]
            [Validation(Required=false)]
            public int? RecordDuration { get; set; }
            [NameInMap("PreRecordDuration")]
            [Validation(Required=false)]
            public int? PreRecordDuration { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }
            [NameInMap("TemplateInfo")]
            [Validation(Required=false)]
            public QueryEventRecordPlanDeviceByDeviceResponseBodyDataTemplateInfo TemplateInfo { get; set; }
            public class QueryEventRecordPlanDeviceByDeviceResponseBodyDataTemplateInfo : TeaModel {
                [NameInMap("TimeSectionList")]
                [Validation(Required=false)]
                public List<QueryEventRecordPlanDeviceByDeviceResponseBodyDataTemplateInfoTimeSectionList> TimeSectionList { get; set; }
                public class QueryEventRecordPlanDeviceByDeviceResponseBodyDataTemplateInfoTimeSectionList : TeaModel {
                    [NameInMap("DayOfWeek")]
                    [Validation(Required=false)]
                    public int? DayOfWeek { get; set; }

                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    [NameInMap("End")]
                    [Validation(Required=false)]
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

            }
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
