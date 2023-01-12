// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIspTypesResponseBody : TeaModel {
        [NameInMap("IspTypeList")]
        [Validation(Required=false)]
        public List<string> IspTypeList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
