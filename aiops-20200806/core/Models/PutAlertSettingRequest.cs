// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class PutAlertSettingRequest : TeaModel {
        [NameInMap("AlarmLevel")]
        [Validation(Required=false)]
        public string AlarmLevel { get; set; }

        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        [NameInMap("AlertSettingId")]
        [Validation(Required=false)]
        public long? AlertSettingId { get; set; }

        [NameInMap("AlertSilenceConfig")]
        [Validation(Required=false)]
        public string AlertSilenceConfig { get; set; }

        [NameInMap("BusinessGroupIdsJson")]
        [Validation(Required=false)]
        public string BusinessGroupIdsJson { get; set; }

        [NameInMap("ContactGroupIdsJson")]
        [Validation(Required=false)]
        public string ContactGroupIdsJson { get; set; }

        [NameInMap("ContactIdsJson")]
        [Validation(Required=false)]
        public string ContactIdsJson { get; set; }

        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public long? CustomerUid { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("SendDingtalkNotice")]
        [Validation(Required=false)]
        public bool? SendDingtalkNotice { get; set; }

        [NameInMap("SendEmailNotice")]
        [Validation(Required=false)]
        public bool? SendEmailNotice { get; set; }

        [NameInMap("SendSmsNotice")]
        [Validation(Required=false)]
        public bool? SendSmsNotice { get; set; }

        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

    }

}
