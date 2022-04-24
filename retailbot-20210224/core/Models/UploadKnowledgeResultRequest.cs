// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UploadKnowledgeResultRequest : TeaModel {
        [NameInMap("DigDatas")]
        [Validation(Required=false)]
        public List<UploadKnowledgeResultRequestDigDatas> DigDatas { get; set; }
        public class UploadKnowledgeResultRequestDigDatas : TeaModel {
            /// <summary>
            /// 商家操作类型       accept 手动采纳       ignore 手动忽略       modify 手动修改       error  错误       other  其他(商家无操作)
            /// </summary>
            [NameInMap("AcceptType")]
            [Validation(Required=false)]
            public string AcceptType { get; set; }

            /// <summary>
            /// 知识类型
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// 答案id
            /// </summary>
            [NameInMap("KmpAnswerId")]
            [Validation(Required=false)]
            public string KmpAnswerId { get; set; }

            /// <summary>
            /// 聚类id
            /// </summary>
            [NameInMap("KmpClusterId")]
            [Validation(Required=false)]
            public string KmpClusterId { get; set; }

            /// <summary>
            /// 采纳后的知识id
            /// </summary>
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public string KnowledgeId { get; set; }

            /// <summary>
            /// 问题id
            /// </summary>
            [NameInMap("QuestionId")]
            [Validation(Required=false)]
            public string QuestionId { get; set; }

            /// <summary>
            /// 问题
            /// </summary>
            [NameInMap("QuestionName")]
            [Validation(Required=false)]
            public string QuestionName { get; set; }

            /// <summary>
            /// 机器人code
            /// </summary>
            [NameInMap("RobotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

            /// <summary>
            /// 场景key
            /// </summary>
            [NameInMap("SceneKey")]
            [Validation(Required=false)]
            public string SceneKey { get; set; }

            /// <summary>
            /// 场景名称
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// solutionId
            /// </summary>
            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public string SolutionId { get; set; }

            /// <summary>
            /// 任务id
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

    }

}
