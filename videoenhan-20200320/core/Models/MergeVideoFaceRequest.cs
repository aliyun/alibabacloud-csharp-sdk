// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoFaceRequest : TeaModel {
        [NameInMap("AddWatermark")]
        [Validation(Required=false)]
        public bool? AddWatermark { get; set; }

        [NameInMap("Enhance")]
        [Validation(Required=false)]
        public bool? Enhance { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReferenceURL")]
        [Validation(Required=false)]
        public string ReferenceURL { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoURL")]
        [Validation(Required=false)]
        public string VideoURL { get; set; }

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
