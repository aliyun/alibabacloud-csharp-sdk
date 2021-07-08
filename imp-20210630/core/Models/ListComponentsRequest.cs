// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListComponentsRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 应用模板唯一标识
        /// </summary>
        [NameInMap("AppTemplateId")]
        [Validation(Required=false)]
        public string AppTemplateId { get; set; }

    }

}
