// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeDialogueNodeStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NoAnswerDialogueNodes")]
        [Validation(Required=false)]
        public List<DescribeDialogueNodeStatisticsResponseBodyNoAnswerDialogueNodes> NoAnswerDialogueNodes { get; set; }
        public class DescribeDialogueNodeStatisticsResponseBodyNoAnswerDialogueNodes : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("HangUpNum")]
            [Validation(Required=false)]
            public int? HangUpNum { get; set; }

            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("NoAnswerNum")]
            [Validation(Required=false)]
            public int? NoAnswerNum { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCompleted")]
        [Validation(Required=false)]
        public int? TotalCompleted { get; set; }

    }

}
