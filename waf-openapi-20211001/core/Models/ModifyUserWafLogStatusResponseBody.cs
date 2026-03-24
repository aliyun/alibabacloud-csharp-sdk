// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyUserWafLogStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the Logstore in Simple Log Service (SLS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>wafng-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>Indicates whether the Simple Log Service project is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wafng-project-14316572********-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public bool? ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-<b><b>-A47C-6B19160</b></b>*</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
