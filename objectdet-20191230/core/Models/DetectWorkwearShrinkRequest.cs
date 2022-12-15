// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectWorkwearShrinkRequest : TeaModel {
        [NameInMap("Clothes")]
        [Validation(Required=false)]
        public string ClothesShrink { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

    }

}
