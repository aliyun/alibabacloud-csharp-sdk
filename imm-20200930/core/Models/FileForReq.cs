// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FileForReq : TeaModel {
        /// <summary>
        /// CustomId
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// CustomLabels
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// FileHash
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// OSSURI
        /// </summary>
        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
