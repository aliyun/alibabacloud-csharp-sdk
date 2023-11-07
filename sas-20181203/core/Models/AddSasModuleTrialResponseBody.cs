// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddSasModuleTrialResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddSasModuleTrialResponseBodyData Data { get; set; }
        public class AddSasModuleTrialResponseBodyData : TeaModel {
            [NameInMap("TrialRecordList")]
            [Validation(Required=false)]
            public List<AddSasModuleTrialResponseBodyDataTrialRecordList> TrialRecordList { get; set; }
            public class AddSasModuleTrialResponseBodyDataTrialRecordList : TeaModel {
                [NameInMap("AuthLimit")]
                [Validation(Required=false)]
                public long? AuthLimit { get; set; }

                [NameInMap("GmtEnd")]
                [Validation(Required=false)]
                public long? GmtEnd { get; set; }

                [NameInMap("GmtStart")]
                [Validation(Required=false)]
                public long? GmtStart { get; set; }

                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
