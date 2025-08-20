// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentHDBodyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentHDBodyResponseBodyData Data { get; set; }
        public class SegmentHDBodyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/segmenthdbody-2020-05-18-16-27-45-675d9884d7-kd9dz/2020-5-18/invi_humansegmenter_015897914589851000001_wQbLq9.png?Expires=1589793259&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=Lx6xSS0t7lqEvy5Qd1keccIAjL">http://viapi-cn-shanghai-dha-segmenter.oss-cn-shanghai.aliyuncs.com/upload/segmenthdbody-2020-05-18-16-27-45-675d9884d7-kd9dz/2020-5-18/invi_humansegmenter_015897914589851000001_wQbLq9.png?Expires=1589793259&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=Lx6xSS0t7lqEvy5Qd1keccIAjL</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A8D3F5C3-E414-4981-8D84-E2CADF0B7CBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
