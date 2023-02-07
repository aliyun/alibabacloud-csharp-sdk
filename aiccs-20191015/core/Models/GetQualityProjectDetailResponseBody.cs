// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityProjectDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityProjectDetailResponseBodyData Data { get; set; }
        public class GetQualityProjectDetailResponseBodyData : TeaModel {
            [NameInMap("CheckFreqType")]
            [Validation(Required=false)]
            public int? CheckFreqType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DepList")]
            [Validation(Required=false)]
            public List<long?> DepList { get; set; }

            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<long?> GroupList { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("QualityRuleIds")]
            [Validation(Required=false)]
            public List<long?> QualityRuleIds { get; set; }

            [NameInMap("QualityType")]
            [Validation(Required=false)]
            public int? QualityType { get; set; }

            [NameInMap("ServicerList")]
            [Validation(Required=false)]
            public List<long?> ServicerList { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
