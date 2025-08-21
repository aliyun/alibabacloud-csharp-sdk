// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetEmonAlarmRecordStatisticsDistributeRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("timeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        [NameInMap("timeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}
