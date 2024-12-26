// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceSignedUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://foo-115**.console.cn-hangzhou.eas.pai-ml.com?expire=1735202661&signature=ey">https://foo-115**.console.cn-hangzhou.eas.pai-ml.com?expire=1735202661&amp;signature=ey</a>*******</para>
        /// </summary>
        [NameInMap("SignedUrl")]
        [Validation(Required=false)]
        public string SignedUrl { get; set; }

    }

}
