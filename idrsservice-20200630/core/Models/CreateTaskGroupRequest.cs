// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class CreateTaskGroupRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Day")]
        [Validation(Required=false)]
        public List<int?> Day { get; set; }

        [NameInMap("ExpireAt")]
        [Validation(Required=false)]
        public string ExpireAt { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("RunnableTimeFrom")]
        [Validation(Required=false)]
        public string RunnableTimeFrom { get; set; }

        [NameInMap("RunnableTimeTo")]
        [Validation(Required=false)]
        public string RunnableTimeTo { get; set; }

        [NameInMap("TriggerPeriod")]
        [Validation(Required=false)]
        public string TriggerPeriod { get; set; }

        [NameInMap("VideoInfo")]
        [Validation(Required=false)]
        public List<CreateTaskGroupRequestVideoInfo> VideoInfo { get; set; }
        public class CreateTaskGroupRequestVideoInfo : TeaModel {
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("VideoMetaUrl")]
            [Validation(Required=false)]
            public string VideoMetaUrl { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

    }

}
