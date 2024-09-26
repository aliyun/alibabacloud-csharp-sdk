// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DesensitizeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned after masking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;desensData&quot;: &quot;<b>198807120510</b>&quot;   }</para>
        /// </summary>
        [NameInMap("DesensitizeData")]
        [Validation(Required=false)]
        public string DesensitizeData { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCA321BA-46C5-40E9-8A08-6******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
