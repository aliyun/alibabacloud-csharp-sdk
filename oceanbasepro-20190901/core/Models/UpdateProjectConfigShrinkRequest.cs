// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class UpdateProjectConfigShrinkRequest : TeaModel {
        [NameInMap("FullTransferConfig")]
        [Validation(Required=false)]
        public string FullTransferConfigShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncrTransferConfig")]
        [Validation(Required=false)]
        public string IncrTransferConfigShrink { get; set; }

        [NameInMap("ReverseIncrTransferConfig")]
        [Validation(Required=false)]
        public string ReverseIncrTransferConfigShrink { get; set; }

    }

}
