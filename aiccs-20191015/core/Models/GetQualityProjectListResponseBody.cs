// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityProjectListResponseBody : TeaModel {
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
        public GetQualityProjectListResponseBodyData Data { get; set; }
        public class GetQualityProjectListResponseBodyData : TeaModel {
            [NameInMap("QualityProjectList")]
            [Validation(Required=false)]
            public List<GetQualityProjectListResponseBodyDataQualityProjectList> QualityProjectList { get; set; }
            public class GetQualityProjectListResponseBodyDataQualityProjectList : TeaModel {
                public int? Status { get; set; }
                public int? QualityType { get; set; }
                public List<string> QualityRuleIds { get; set; }
                public string CreateTime { get; set; }
                public string ProjectName { get; set; }
                public int? CheckFreqType { get; set; }
                public List<string> DepList { get; set; }
                public List<string> ServicerList { get; set; }
                public int? Version { get; set; }
                public List<string> GroupList { get; set; }
                public long? Id { get; set; }
                public string ModifyTime { get; set; }
            }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
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
        public bool? Success { get; set; }

    }

}
