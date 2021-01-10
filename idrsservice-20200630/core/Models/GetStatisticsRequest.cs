// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetStatisticsRequest : TeaModel {
        [NameInMap("DateFrom")]
        [Validation(Required=false)]
        public string DateFrom { get; set; }

        [NameInMap("DateTo")]
        [Validation(Required=false)]
        public string DateTo { get; set; }

        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public List<string> DepartmentId { get; set; }

    }

}
