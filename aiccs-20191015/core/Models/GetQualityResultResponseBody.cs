// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityResultResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityResultResponseBodyData Data { get; set; }
        public class GetQualityResultResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("QualityResultResponseList")]
            [Validation(Required=false)]
            public List<GetQualityResultResponseBodyDataQualityResultResponseList> QualityResultResponseList { get; set; }
            public class GetQualityResultResponseBodyDataQualityResultResponseList : TeaModel {
                public string TouchId { get; set; }
                public string ServicerName { get; set; }
                public string MemberName { get; set; }
                public string ProjectName { get; set; }
                public string ProjectId { get; set; }
                public string ChannelType { get; set; }
                public string ChannelTypeName { get; set; }
                public string TouchStartTime { get; set; }
                public string ServicerId { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
                public string GroupName { get; set; }
                public string GroupId { get; set; }
                public string InstanceName { get; set; }
                public bool? HitStatus { get; set; }
                public string HitDetail { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ChannelTypeName")]
        [Validation(Required=false)]
        public string ChannelTypeName { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
