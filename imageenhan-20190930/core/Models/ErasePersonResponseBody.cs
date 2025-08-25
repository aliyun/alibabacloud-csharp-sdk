// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ErasePersonResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ErasePersonResponseBodyData Data { get; set; }
        public class ErasePersonResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-isr-lab-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/remove-person/2020-10-29_10%3A59%3A21.421276_img19.png?Expires=1603970961&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=9lBakx0r6FOssTEYTcKs5pk8ta">http://algo-app-isr-lab-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/remove-person/2020-10-29_10%3A59%3A21.421276_img19.png?Expires=1603970961&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=9lBakx0r6FOssTEYTcKs5pk8ta</a>****</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FEDA495-9A5D-48B5-8922-98A4FE01D381</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
