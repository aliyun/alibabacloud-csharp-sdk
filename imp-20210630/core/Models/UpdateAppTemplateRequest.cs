// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class UpdateAppTemplateRequest : TeaModel {
        /// <summary>
        /// 应用模板唯一标识
        /// </summary>
        [NameInMap("AppTemplateId")]
        [Validation(Required=false)]
        public string AppTemplateId { get; set; }

        /// <summary>
        /// 应用模板名称
        /// </summary>
        [NameInMap("AppTemplateName")]
        [Validation(Required=false)]
        public string AppTemplateName { get; set; }

    }

}
