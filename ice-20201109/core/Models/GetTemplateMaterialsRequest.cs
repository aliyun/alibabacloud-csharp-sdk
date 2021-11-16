// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateMaterialsRequest : TeaModel {
        /// <summary>
        /// 所需文件列表
        /// </summary>
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public string FileList { get; set; }

        /// <summary>
        /// 模板Id
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
