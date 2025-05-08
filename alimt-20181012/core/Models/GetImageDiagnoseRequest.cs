// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetImageDiagnoseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{   &quot;product_id&quot;: &quot;1&quot;,   &quot;platform&quot;: &quot;ae&quot; }</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxx.oss-cn-shenzhen.aliyuncs.com/jd/41209/xxxxx.jpg">http://xxxxx.oss-cn-shenzhen.aliyuncs.com/jd/41209/xxxxx.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
