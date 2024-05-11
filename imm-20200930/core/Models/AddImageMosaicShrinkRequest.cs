// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AddImageMosaicShrinkRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Quality")]
        [Validation(Required=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public string TargetsShrink { get; set; }

    }

}
