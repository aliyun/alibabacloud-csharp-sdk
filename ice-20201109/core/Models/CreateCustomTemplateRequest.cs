// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateCustomTemplateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Subtype")]
        [Validation(Required=false)]
        public int? Subtype { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
