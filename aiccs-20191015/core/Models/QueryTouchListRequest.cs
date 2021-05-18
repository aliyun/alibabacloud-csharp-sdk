// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("FirstTimeStart")]
        [Validation(Required=false)]
        public long? FirstTimeStart { get; set; }

        [NameInMap("FirstTimeEnd")]
        [Validation(Required=false)]
        public long? FirstTimeEnd { get; set; }

        [NameInMap("CloseTimeStart")]
        [Validation(Required=false)]
        public long? CloseTimeStart { get; set; }

        [NameInMap("CloseTimeEnd")]
        [Validation(Required=false)]
        public long? CloseTimeEnd { get; set; }

        [NameInMap("TouchId")]
        [Validation(Required=false)]
        public List<long?> TouchId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public List<string> ChannelId { get; set; }

        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public List<int?> ChannelType { get; set; }

        [NameInMap("TouchType")]
        [Validation(Required=false)]
        public List<int?> TouchType { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public List<long?> MemberId { get; set; }

        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public List<string> MemberName { get; set; }

        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public List<long?> ServicerId { get; set; }

        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public List<string> ServicerName { get; set; }

        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public List<long?> QueueId { get; set; }

        [NameInMap("EvaluationStatus")]
        [Validation(Required=false)]
        public List<int?> EvaluationStatus { get; set; }

        [NameInMap("EvaluationLevel")]
        [Validation(Required=false)]
        public List<int?> EvaluationLevel { get; set; }

        [NameInMap("EvaluationScore")]
        [Validation(Required=false)]
        public List<int?> EvaluationScore { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
