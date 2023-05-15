// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOrUpdateDingTalkRequest : TeaModel {
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public string ConfigList { get; set; }

        [NameInMap("DingTalkLang")]
        [Validation(Required=false)]
        public string DingTalkLang { get; set; }

        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public long? IntervalTime { get; set; }

        [NameInMap("RuleActionName")]
        [Validation(Required=false)]
        public string RuleActionName { get; set; }

        [NameInMap("SendUrl")]
        [Validation(Required=false)]
        public string SendUrl { get; set; }

    }

}
