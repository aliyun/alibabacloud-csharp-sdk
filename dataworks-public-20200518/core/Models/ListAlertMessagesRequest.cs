// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesRequest : TeaModel {
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        [NameInMap("AlertRuleTypes")]
        [Validation(Required=false)]
        public string AlertRuleTypes { get; set; }

        [NameInMap("AlertUser")]
        [Validation(Required=false)]
        public string AlertUser { get; set; }

        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

    }

}
