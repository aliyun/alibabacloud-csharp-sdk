// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class UpdateAntChainContractContentRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContentId")]
        [Validation(Required=false)]
        public string ContentId { get; set; }

        [NameInMap("ContentName")]
        [Validation(Required=false)]
        public string ContentName { get; set; }

        [NameInMap("ParentContentId")]
        [Validation(Required=false)]
        public string ParentContentId { get; set; }

    }

}
