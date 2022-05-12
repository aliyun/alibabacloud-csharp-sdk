// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemRequest : TeaModel {
        /// <summary>
        /// 工作项负责人的account id，或者企业中的用户名
        /// </summary>
        [NameInMap("assignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        /// <summary>
        /// 工作项的类型id，比如：Bug、Task对应id
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 工作项内容
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 内容格式
        /// </summary>
        [NameInMap("descriptionFormat")]
        [Validation(Required=false)]
        public string DescriptionFormat { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [NameInMap("fieldValueList")]
        [Validation(Required=false)]
        public List<CreateWorkitemRequestFieldValueList> FieldValueList { get; set; }
        public class CreateWorkitemRequestFieldValueList : TeaModel {
            /// <summary>
            /// 字段唯一标识
            /// </summary>
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            /// <summary>
            /// 字段值，写入时使用
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// 工作项的唯一标识
            /// </summary>
            [NameInMap("workitemIdentifier")]
            [Validation(Required=false)]
            public string WorkitemIdentifier { get; set; }

        }

        /// <summary>
        /// 所属父工作项的唯一标识
        /// </summary>
        [NameInMap("parent")]
        [Validation(Required=false)]
        public string Parent { get; set; }

        /// <summary>
        /// 参与人account id列表，或者企业名称列表
        /// </summary>
        [NameInMap("participant")]
        [Validation(Required=false)]
        public List<string> Participant { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [NameInMap("space")]
        [Validation(Required=false)]
        public string Space { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        /// <summary>
        /// 要关联迭代
        /// </summary>
        [NameInMap("sprint")]
        [Validation(Required=false)]
        public List<string> Sprint { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 抄送人account id列表
        /// </summary>
        [NameInMap("tracker")]
        [Validation(Required=false)]
        public List<string> Tracker { get; set; }

        /// <summary>
        /// 验证者account id列表，或者企业名称列表
        /// </summary>
        [NameInMap("verifier")]
        [Validation(Required=false)]
        public List<string> Verifier { get; set; }

        /// <summary>
        /// 工作项小类型id
        /// </summary>
        [NameInMap("workitemType")]
        [Validation(Required=false)]
        public string WorkitemType { get; set; }

    }

}
