// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class AssignJobsRequest : TeaModel {
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsAsynchrony")]
        [Validation(Required=false)]
        public bool? IsAsynchrony { get; set; }

        [NameInMap("JobDataParsingTaskId")]
        [Validation(Required=false)]
        public string JobDataParsingTaskId { get; set; }

        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("JobsJson")]
        [Validation(Required=false)]
        public List<string> JobsJson { get; set; }

        [NameInMap("RosterType")]
        [Validation(Required=false)]
        public string RosterType { get; set; }

        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
