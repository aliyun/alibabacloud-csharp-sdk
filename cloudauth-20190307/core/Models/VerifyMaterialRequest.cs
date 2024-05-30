// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyMaterialRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FaceImageUrl")]
        [Validation(Required=false)]
        public string FaceImageUrl { get; set; }

        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
