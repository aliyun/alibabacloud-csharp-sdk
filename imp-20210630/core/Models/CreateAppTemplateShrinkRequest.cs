// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateAppTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// 应用模板名称
        /// </summary>
        [NameInMap("AppTemplateName")]
        [Validation(Required=false)]
        public string AppTemplateName { get; set; }

        /// <summary>
        /// 组件列表
        /// </summary>
        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public string ComponentListShrink { get; set; }

    }

}
