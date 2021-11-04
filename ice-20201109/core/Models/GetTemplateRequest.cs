// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateRequest : TeaModel {
        /// <summary>
        /// 是否返回模板关联素材，1返回，默认0，不返回
        /// </summary>
        [NameInMap("RelatedMediaidFlag")]
        [Validation(Required=false)]
        public string RelatedMediaidFlag { get; set; }

        /// <summary>
        /// 模板Id
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
