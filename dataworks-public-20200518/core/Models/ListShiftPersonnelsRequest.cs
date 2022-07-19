// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftPersonnelsRequest : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ShiftPersonUID")]
        [Validation(Required=false)]
        public string ShiftPersonUID { get; set; }

        [NameInMap("ShiftScheduleIdentifier")]
        [Validation(Required=false)]
        public string ShiftScheduleIdentifier { get; set; }

        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
