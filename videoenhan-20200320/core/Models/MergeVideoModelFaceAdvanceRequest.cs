// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceAdvanceRequest : TeaModel {
        [NameInMap("FaceImageURLObject")]
        [Validation(Required=true)]
        public Stream FaceImageURLObject { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
