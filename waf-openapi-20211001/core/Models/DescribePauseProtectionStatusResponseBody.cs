// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePauseProtectionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether WAF protection is paused.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: indicates that WAF protection is not paused. This is the default value.</description></item>
        /// <item><description><b>1</b>: indicates that WAF protection is paused.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PauseStatus")]
        [Validation(Required=false)]
        public int? PauseStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-<b><b>-46CE-A47C-6B19</b></b>5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
