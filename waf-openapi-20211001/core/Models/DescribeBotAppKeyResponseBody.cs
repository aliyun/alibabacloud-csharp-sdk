// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBotAppKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>AppKey。</para>
        /// 
        /// <b>Example:</b>
        /// <para>N1Kiv3AGZm******</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C4ADFD4-5B7D-591D-A607-A45C*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
