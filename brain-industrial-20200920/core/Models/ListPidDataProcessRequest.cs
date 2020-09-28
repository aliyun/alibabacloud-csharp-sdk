// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidDataProcessRequest : TeaModel {
        [NameInMap("PidLoopId")]
        [Validation(Required=true)]
        public string PidLoopId { get; set; }

        [NameInMap("OnlyCompleteStatus")]
        [Validation(Required=true)]
        public bool? OnlyCompleteStatus { get; set; }

        [NameInMap("PidDataProcessType")]
        [Validation(Required=true)]
        public string PidDataProcessType { get; set; }

    }

}
