// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockProcessStatusRequest : TeaModel {
        [NameInMap("DealAll")]
        [Validation(Required=false)]
        public int? DealAll { get; set; }

        [NameInMap("OperateInfo")]
        [Validation(Required=false)]
        public string OperateInfo { get; set; }

        [NameInMap("ProcessPath")]
        [Validation(Required=false)]
        public List<string> ProcessPath { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
