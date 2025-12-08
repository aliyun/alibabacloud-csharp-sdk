// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class EnhanceFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnhanceFaceResponseBodyData Data { get; set; }
        public class EnhanceFaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/face-enhancement/2021-11-30/8e34b61c-abcf-4708-9d9d-6501968ee806/20211130_080644126523_47ct9w3pgh.jpg?Expires=1638261404&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=2wPdcuCmr%2F86WpBL3HQJw5uCFl">http://vibktprfx-prod-prod-aic-vd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/face-enhancement/2021-11-30/8e34b61c-abcf-4708-9d9d-6501968ee806/20211130_080644126523_47ct9w3pgh.jpg?Expires=1638261404&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=2wPdcuCmr%2F86WpBL3HQJw5uCFl</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8B031473-6773-4A4C-AF33-A233758E6E98</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
