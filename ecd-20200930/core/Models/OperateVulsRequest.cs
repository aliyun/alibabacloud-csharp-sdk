// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class OperateVulsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Precondition")]
        [Validation(Required=false)]
        public int? Precondition { get; set; }

        [NameInMap("VulName")]
        [Validation(Required=false)]
        public List<string> VulName { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

    }

}
