// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMassMessageRequest : TeaModel {
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("SenderList")]
        [Validation(Required=false)]
        public List<SendChatappMassMessageRequestSenderList> SenderList { get; set; }
        public class SendChatappMassMessageRequestSenderList : TeaModel {
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public List<string> Payload { get; set; }

            [NameInMap("TemplateParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateParams { get; set; }

            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
