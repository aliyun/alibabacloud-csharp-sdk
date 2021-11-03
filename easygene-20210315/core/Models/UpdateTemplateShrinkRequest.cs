// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class UpdateTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// 应用模板描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 应用的输入
        /// </summary>
        [NameInMap("InputsExpression")]
        [Validation(Required=false)]
        public string InputsExpressionShrink { get; set; }

        /// <summary>
        /// 应用模板标签
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// 应用的输出
        /// </summary>
        [NameInMap("OutputsExpression")]
        [Validation(Required=false)]
        public string OutputsExpressionShrink { get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        [NameInMap("RootEntity")]
        [Validation(Required=false)]
        public string RootEntity { get; set; }

        /// <summary>
        /// 应用模板名称
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 工作空间名称
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
