// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class CreateTaskOrderByEventReportShrinkRequest : TeaModel {
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
        public string EventBodyShrink { get; set; }

        [NameInMap("Extinfo")]
        [Validation(Required=false)]
        public string ExtinfoShrink { get; set; }

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
