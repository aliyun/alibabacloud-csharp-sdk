// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateNotifyRequest : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("IdempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("NotifyElement")]
        [Validation(Required=false)]
        public string NotifyElement { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
