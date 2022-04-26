// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListMultiChannelRecordingsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMultiChannelRecordingsResponseBodyData> Data { get; set; }
        public class ListMultiChannelRecordingsResponseBodyData : TeaModel {
            [NameInMap("AgentChannelId")]
            [Validation(Required=false)]
            public string AgentChannelId { get; set; }

            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("RamId")]
            [Validation(Required=false)]
            public string RamId { get; set; }

            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
