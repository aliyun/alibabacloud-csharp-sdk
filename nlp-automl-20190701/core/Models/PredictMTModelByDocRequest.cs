// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class PredictMTModelByDocRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileContent")]
        [Validation(Required=false)]
        public string FileContent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public int? ModelId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        [NameInMap("NeedXLIFF")]
        [Validation(Required=false)]
        public bool? NeedXLIFF { get; set; }

    }

}
