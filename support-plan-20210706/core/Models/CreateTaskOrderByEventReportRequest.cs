// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class CreateTaskOrderByEventReportRequest : TeaModel {
        [NameInMap("Business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CreateRealName")]
        [Validation(Required=false)]
        public string CreateRealName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("EventBody")]
        [Validation(Required=false)]
        public CreateTaskOrderByEventReportRequestEventBody EventBody { get; set; }
        public class CreateTaskOrderByEventReportRequestEventBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("EventDesc")]
            [Validation(Required=false)]
            public string EventDesc { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            [NameInMap("EventLocation")]
            [Validation(Required=false)]
            public CreateTaskOrderByEventReportRequestEventBodyEventLocation EventLocation { get; set; }
            public class CreateTaskOrderByEventReportRequestEventBodyEventLocation : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

            }

            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

        }

        [NameInMap("Extinfo")]
        [Validation(Required=false)]
        public List<CreateTaskOrderByEventReportRequestExtinfo> Extinfo { get; set; }
        public class CreateTaskOrderByEventReportRequestExtinfo : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ImportantDesc")]
        [Validation(Required=false)]
        public string ImportantDesc { get; set; }

        [NameInMap("JoinChildGroupUserIds")]
        [Validation(Required=false)]
        public string JoinChildGroupUserIds { get; set; }

        [NameInMap("MonitorCongregation")]
        [Validation(Required=false)]
        public string MonitorCongregation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
