// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class CreateOperatorRequest : TeaModel {
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("BgObject")]
        [Validation(Required=false)]
        public string BgObject { get; set; }

        [NameInMap("BgSystem")]
        [Validation(Required=false)]
        public string BgSystem { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurEmpId")]
        [Validation(Required=false)]
        public string CurEmpId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NoCheck")]
        [Validation(Required=false)]
        public bool? NoCheck { get; set; }

        [NameInMap("NoRisk")]
        [Validation(Required=false)]
        public bool? NoRisk { get; set; }

        [NameInMap("ReqTimestamp")]
        [Validation(Required=false)]
        public long? ReqTimestamp { get; set; }

    }

}
