/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class AddMTInterveneWordRequest : TeaModel {
        [NameInMap("PackageId")]
        [Validation(Required=false)]
        public string PackageId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceText")]
        [Validation(Required=false)]
        public string SourceText { get; set; }

        [NameInMap("TargetText")]
        [Validation(Required=false)]
        public string TargetText { get; set; }

    }

}
