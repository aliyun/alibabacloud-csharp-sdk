// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class DeleteSmsTemplateNewResponseBody : TeaModel {
        [NameInMap("FailList")]
        [Validation(Required=false)]
        public DeleteSmsTemplateNewResponseBodyFailList FailList { get; set; }
        public class DeleteSmsTemplateNewResponseBodyFailList : TeaModel {
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public List<string> Fail { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public DeleteSmsTemplateNewResponseBodySuccessList SuccessList { get; set; }
        public class DeleteSmsTemplateNewResponseBodySuccessList : TeaModel {
            [NameInMap("Succes")]
            [Validation(Required=false)]
            public List<string> Succes { get; set; }

        }

    }

}
