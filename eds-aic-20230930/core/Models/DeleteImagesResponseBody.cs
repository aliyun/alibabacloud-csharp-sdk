// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DeleteImagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteImagesResponseBodyData Data { get; set; }
        public class DeleteImagesResponseBodyData : TeaModel {
            [NameInMap("FailDeleteImageIds")]
            [Validation(Required=false)]
            public List<string> FailDeleteImageIds { get; set; }

            [NameInMap("SuccessDeleteImageIds")]
            [Validation(Required=false)]
            public List<string> SuccessDeleteImageIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4610632D-D661-5982-B3D7-5D3FD183F595</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
