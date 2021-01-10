// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveClriskTemplateRequest : TeaModel {
        [NameInMap("DataNodesRepeatList")]
        [Validation(Required=false)]
        public List<string> DataNodesRepeatList { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("OwnersRepeatList")]
        [Validation(Required=false)]
        public List<string> OwnersRepeatList { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TriggerDelay")]
        [Validation(Required=false)]
        public string TriggerDelay { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
