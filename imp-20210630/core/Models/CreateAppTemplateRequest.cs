// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateAppTemplateRequest : TeaModel {
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
        public List<string> ComponentList { get; set; }

        /// <summary>
        /// 集成方式（一体化SDK：paasSDK，样板间：standardRoom）
        /// </summary>
        [NameInMap("IntegrationMode")]
        [Validation(Required=false)]
        public string IntegrationMode { get; set; }

        /// <summary>
        /// 应用模板场景，电商business，课堂classroom
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
