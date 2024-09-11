// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleMetaVerifyV2Request : TeaModel {
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("VehicleNum")]
        [Validation(Required=false)]
        public string VehicleNum { get; set; }

        [NameInMap("VehicleType")]
        [Validation(Required=false)]
        public string VehicleType { get; set; }

        [NameInMap("VerifyMetaType")]
        [Validation(Required=false)]
        public string VerifyMetaType { get; set; }

    }

}
