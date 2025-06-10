// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class SegmentLymphNodeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentLymphNodeResponseBodyData Data { get; set; }
        public class SegmentLymphNodeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-med-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/seg-organ-ct/2023-03-06/18%3A03%3A28/286574099408093190.nii.gz?Expires=1678098808&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=jsPwP7rg4orZQFC6USE3JUOJcS">http://vibktprfx-prod-prod-med-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/seg-organ-ct/2023-03-06/18%3A03%3A28/286574099408093190.nii.gz?Expires=1678098808&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=jsPwP7rg4orZQFC6USE3JUOJcS</a>****</para>
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
        /// <para>B48DECE6-29FE-1967-92F1-2E072873851A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
