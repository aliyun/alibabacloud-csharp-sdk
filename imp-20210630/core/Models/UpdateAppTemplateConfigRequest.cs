// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class UpdateAppTemplateConfigRequest : TeaModel {
        /// <summary>
        /// 应用模板唯一标识
        /// </summary>
        [NameInMap("AppTemplateId")]
        [Validation(Required=false)]
        public string AppTemplateId { get; set; }

        /// <summary>
        /// 更新配置
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<UpdateAppTemplateConfigRequestConfigList> ConfigList { get; set; }
        public class UpdateAppTemplateConfigRequestConfigList : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
