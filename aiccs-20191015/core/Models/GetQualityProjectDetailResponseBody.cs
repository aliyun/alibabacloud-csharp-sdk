// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityProjectDetailResponseBody : TeaModel {
        /// <summary>
        /// Message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityProjectDetailResponseBodyData Data { get; set; }
        public class GetQualityProjectDetailResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("QualityType")]
            [Validation(Required=false)]
            public int? QualityType { get; set; }
            [NameInMap("QualityRuleIds")]
            [Validation(Required=false)]
            public List<string> QualityRuleIds { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
            [NameInMap("CheckFreqType")]
            [Validation(Required=false)]
            public int? CheckFreqType { get; set; }
            [NameInMap("DepList")]
            [Validation(Required=false)]
            public List<string> DepList { get; set; }
            [NameInMap("ServicerList")]
            [Validation(Required=false)]
            public List<string> ServicerList { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<string> GroupList { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
        };

        /// <summary>
        /// Code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
