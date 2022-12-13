// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListEscalationPlansByNoticeObjectRequest : TeaModel {
        [NameInMap("noticeObjectId")]
        [Validation(Required=false)]
        public long? NoticeObjectId { get; set; }

        [NameInMap("noticeObjectType")]
        [Validation(Required=false)]
        public long? NoticeObjectType { get; set; }

    }

}
