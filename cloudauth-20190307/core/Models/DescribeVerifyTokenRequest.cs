// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyTokenRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CallbackSeed")]
        [Validation(Required=false)]
        public string CallbackSeed { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("FaceRetainedImageUrl")]
        [Validation(Required=false)]
        public string FaceRetainedImageUrl { get; set; }

        [NameInMap("FailedRedirectUrl")]
        [Validation(Required=false)]
        public string FailedRedirectUrl { get; set; }

        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PassedRedirectUrl")]
        [Validation(Required=false)]
        public string PassedRedirectUrl { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserIp")]
        [Validation(Required=false)]
        public string UserIp { get; set; }

        [NameInMap("UserPhoneNumber")]
        [Validation(Required=false)]
        public string UserPhoneNumber { get; set; }

        [NameInMap("UserRegistTime")]
        [Validation(Required=false)]
        public long? UserRegistTime { get; set; }

    }

}
