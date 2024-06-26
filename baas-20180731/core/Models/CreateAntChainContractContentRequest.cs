// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateAntChainContractContentRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContentName")]
        [Validation(Required=false)]
        public string ContentName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IsDirectory")]
        [Validation(Required=false)]
        public bool? IsDirectory { get; set; }

        [NameInMap("ParentContentId")]
        [Validation(Required=false)]
        public string ParentContentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
