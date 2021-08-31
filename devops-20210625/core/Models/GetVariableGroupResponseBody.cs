// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetVariableGroupResponseBody : TeaModel {
        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 变量组
        /// </summary>
        [NameInMap("variableGroup")]
        [Validation(Required=false)]
        public GetVariableGroupResponseBodyVariableGroup VariableGroup { get; set; }
        public class GetVariableGroupResponseBodyVariableGroup : TeaModel {
            [NameInMap("ccreatorAccountId")]
            [Validation(Required=false)]
            public string CcreatorAccountId { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("relatedPipelines")]
            [Validation(Required=false)]
            public List<GetVariableGroupResponseBodyVariableGroupRelatedPipelines> RelatedPipelines { get; set; }
            public class GetVariableGroupResponseBodyVariableGroupRelatedPipelines : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<GetVariableGroupResponseBodyVariableGroupVariables> Variables { get; set; }
            public class GetVariableGroupResponseBodyVariableGroupVariables : TeaModel {
                public string Value { get; set; }
                public string Name { get; set; }
                public bool? IsEncrypted { get; set; }
            }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
        };

    }

}
