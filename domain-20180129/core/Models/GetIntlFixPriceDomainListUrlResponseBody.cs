// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class GetIntlFixPriceDomainListUrlResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetIntlFixPriceDomainListUrlResponseBodyModule Module { get; set; }
        public class GetIntlFixPriceDomainListUrlResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://intl-fixed-price.oss-cn-zhangjiakou.aliyuncs.com/aliyun_intl_fixed_price_domain_20240827.gz?Expires=1724830838&OSSAccessKeyId=LTAI5tPMAybR4gfSEjdfAk1F&Signature=tb0SPs6tKb9gLKyQ5ibpQnBUuTY%3D">http://intl-fixed-price.oss-cn-zhangjiakou.aliyuncs.com/aliyun_intl_fixed_price_domain_20240827.gz?Expires=1724830838&amp;OSSAccessKeyId=LTAI5tPMAybR4gfSEjdfAk1F&amp;Signature=tb0SPs6tKb9gLKyQ5ibpQnBUuTY%3D</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BF014B60-C708-4253-B5F2-3F9B493F398B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
