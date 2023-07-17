// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListDialogueTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDialogueTemplateResponseBodyResult> Result { get; set; }
        public class ListDialogueTemplateResponseBodyResult : TeaModel {
            [NameInMap("TemplateDetail")]
            [Validation(Required=false)]
            public ListDialogueTemplateResponseBodyResultTemplateDetail TemplateDetail { get; set; }
            public class ListDialogueTemplateResponseBodyResultTemplateDetail : TeaModel {
                [NameInMap("FirstDialogueTemplate")]
                [Validation(Required=false)]
                public ListDialogueTemplateResponseBodyResultTemplateDetailFirstDialogueTemplate FirstDialogueTemplate { get; set; }
                public class ListDialogueTemplateResponseBodyResultTemplateDetailFirstDialogueTemplate : TeaModel {
                    [NameInMap("NonzeroPriceYesAnswer")]
                    [Validation(Required=false)]
                    public string NonzeroPriceYesAnswer { get; set; }

                    [NameInMap("ZeroPriceNoAnswer")]
                    [Validation(Required=false)]
                    public string ZeroPriceNoAnswer { get; set; }

                    [NameInMap("ZeroPriceYesAnswer")]
                    [Validation(Required=false)]
                    public string ZeroPriceYesAnswer { get; set; }

                }

                [NameInMap("SecondDialogueTemplate")]
                [Validation(Required=false)]
                public ListDialogueTemplateResponseBodyResultTemplateDetailSecondDialogueTemplate SecondDialogueTemplate { get; set; }
                public class ListDialogueTemplateResponseBodyResultTemplateDetailSecondDialogueTemplate : TeaModel {
                    [NameInMap("NonzeroPriceNoAnswer")]
                    [Validation(Required=false)]
                    public string NonzeroPriceNoAnswer { get; set; }

                    [NameInMap("NonzeroPriceYesAnswer")]
                    [Validation(Required=false)]
                    public string NonzeroPriceYesAnswer { get; set; }

                }

            }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
