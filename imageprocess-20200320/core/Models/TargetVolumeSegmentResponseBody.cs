// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class TargetVolumeSegmentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TargetVolumeSegmentResponseBodyData Data { get; set; }
        public class TargetVolumeSegmentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-med-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/seg-organ-ct/2023-01-31/13%3A59%3A57/286304994262646784.nii.gz?Expires=1675146629&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=L7jGtdydjfaFxQQCwqe4q4hlHz">http://vibktprfx-prod-prod-med-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/seg-organ-ct/2023-01-31/13%3A59%3A57/286304994262646784.nii.gz?Expires=1675146629&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=L7jGtdydjfaFxQQCwqe4q4hlHz</a>****</para>
            /// </summary>
            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6cc7232e-d38b-4dda-b86d-6e0e31704fa1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
