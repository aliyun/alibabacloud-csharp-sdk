// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnVerifyContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The verification result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_dffeb6610035dcb78b413a59c31cd9**</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AB41F1-04A5-496F-8C8D-634BDBE6A9FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
