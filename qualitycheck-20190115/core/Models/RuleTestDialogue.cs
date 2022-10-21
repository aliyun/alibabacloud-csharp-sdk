// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RuleTestDialogue : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<RuleTestDialogueContent> Content { get; set; }
        public class RuleTestDialogueContent : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public long? Begin { get; set; }

            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            [NameInMap("EmotionValue")]
            [Validation(Required=false)]
            public int? EmotionValue { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            [NameInMap("HourMinSec")]
            [Validation(Required=false)]
            public string HourMinSec { get; set; }

            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("SilenceDuration")]
            [Validation(Required=false)]
            public long? SilenceDuration { get; set; }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public long? SpeechRate { get; set; }

            [NameInMap("Words")]
            [Validation(Required=false)]
            public string Words { get; set; }

        }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
