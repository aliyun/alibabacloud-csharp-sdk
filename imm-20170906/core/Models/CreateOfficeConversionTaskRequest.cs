// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateOfficeConversionTaskRequest : TeaModel {
        [NameInMap("DisplayDpi")]
        [Validation(Required=false)]
        public int? DisplayDpi { get; set; }

        [NameInMap("EndPage")]
        [Validation(Required=false)]
        public long? EndPage { get; set; }

        [NameInMap("FitToPagesTall")]
        [Validation(Required=false)]
        public bool? FitToPagesTall { get; set; }

        [NameInMap("FitToPagesWide")]
        [Validation(Required=false)]
        public bool? FitToPagesWide { get; set; }

        [NameInMap("Hidecomments")]
        [Validation(Required=false)]
        public bool? Hidecomments { get; set; }

        [NameInMap("IdempotentToken")]
        [Validation(Required=false)]
        public string IdempotentToken { get; set; }

        [NameInMap("MaxSheetCol")]
        [Validation(Required=false)]
        public long? MaxSheetCol { get; set; }

        [NameInMap("MaxSheetCount")]
        [Validation(Required=false)]
        public long? MaxSheetCount { get; set; }

        [NameInMap("MaxSheetRow")]
        [Validation(Required=false)]
        public long? MaxSheetRow { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PdfVector")]
        [Validation(Required=false)]
        public bool? PdfVector { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SheetOnePage")]
        [Validation(Required=false)]
        public bool? SheetOnePage { get; set; }

        [NameInMap("SrcType")]
        [Validation(Required=false)]
        public string SrcType { get; set; }

        [NameInMap("SrcUri")]
        [Validation(Required=false)]
        public string SrcUri { get; set; }

        [NameInMap("StartPage")]
        [Validation(Required=false)]
        public long? StartPage { get; set; }

        [NameInMap("TgtFilePages")]
        [Validation(Required=false)]
        public string TgtFilePages { get; set; }

        [NameInMap("TgtFilePrefix")]
        [Validation(Required=false)]
        public string TgtFilePrefix { get; set; }

        [NameInMap("TgtFileSuffix")]
        [Validation(Required=false)]
        public string TgtFileSuffix { get; set; }

        [NameInMap("TgtType")]
        [Validation(Required=false)]
        public string TgtType { get; set; }

        [NameInMap("TgtUri")]
        [Validation(Required=false)]
        public string TgtUri { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
