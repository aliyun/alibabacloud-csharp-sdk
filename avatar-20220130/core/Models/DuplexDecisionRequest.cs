// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class DuplexDecisionRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("BizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public int? CallTime { get; set; }

        [NameInMap("CustomKeywords")]
        [Validation(Required=false)]
        public List<string> CustomKeywords { get; set; }

        [NameInMap("DialogContext")]
        [Validation(Required=false)]
        public DuplexDecisionRequestDialogContext DialogContext { get; set; }
        public class DuplexDecisionRequestDialogContext : TeaModel {
            [NameInMap("CurUtteranceIdx")]
            [Validation(Required=false)]
            public int? CurUtteranceIdx { get; set; }

            [NameInMap("Histories")]
            [Validation(Required=false)]
            public List<DuplexDecisionRequestDialogContextHistories> Histories { get; set; }
            public class DuplexDecisionRequestDialogContextHistories : TeaModel {
                [NameInMap("Robot")]
                [Validation(Required=false)]
                public string Robot { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

        [NameInMap("DialogStatus")]
        [Validation(Required=false)]
        public string DialogStatus { get; set; }

        [NameInMap("InterruptType")]
        [Validation(Required=false)]
        public int? InterruptType { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
