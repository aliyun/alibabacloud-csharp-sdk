// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class AddCdrsMonitorRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("MonitorType")]
        [Validation(Required=false)]
        public string MonitorType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("BatchIndicator")]
        [Validation(Required=false)]
        public int? BatchIndicator { get; set; }

        [NameInMap("AlgorithmVendor")]
        [Validation(Required=false)]
        public string AlgorithmVendor { get; set; }

        [NameInMap("NotifierType")]
        [Validation(Required=false)]
        public string NotifierType { get; set; }

        [NameInMap("NotifierUrl")]
        [Validation(Required=false)]
        public string NotifierUrl { get; set; }

        [NameInMap("NotifierAppSecret")]
        [Validation(Required=false)]
        public string NotifierAppSecret { get; set; }

        [NameInMap("NotifierTimeOut")]
        [Validation(Required=false)]
        public int? NotifierTimeOut { get; set; }

        [NameInMap("NotifierExtendValues")]
        [Validation(Required=false)]
        public string NotifierExtendValues { get; set; }

    }

}
