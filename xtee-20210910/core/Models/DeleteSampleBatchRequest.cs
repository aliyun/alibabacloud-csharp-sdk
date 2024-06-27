// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DeleteSampleBatchRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

    }

}
