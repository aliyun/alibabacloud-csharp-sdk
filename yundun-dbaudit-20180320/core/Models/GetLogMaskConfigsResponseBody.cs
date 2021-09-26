// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogMaskConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<GetLogMaskConfigsResponseBodyConfigs> Configs { get; set; }
        public class GetLogMaskConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("MaskDescription")]
            [Validation(Required=false)]
            public string MaskDescription { get; set; }

            [NameInMap("MaskState")]
            [Validation(Required=false)]
            public int? MaskState { get; set; }

            [NameInMap("MaskName")]
            [Validation(Required=false)]
            public string MaskName { get; set; }

            [NameInMap("MaskRegex")]
            [Validation(Required=false)]
            public string MaskRegex { get; set; }

            [NameInMap("MaskTxt")]
            [Validation(Required=false)]
            public string MaskTxt { get; set; }

            [NameInMap("MaskId")]
            [Validation(Required=false)]
            public int? MaskId { get; set; }

            [NameInMap("MaskType")]
            [Validation(Required=false)]
            public int? MaskType { get; set; }

        }

    }

}
