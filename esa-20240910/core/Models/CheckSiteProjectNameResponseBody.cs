// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CheckSiteProjectNameResponseBody : TeaModel {
        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Can be added.</description></item>
        /// <item><description><b>false</b>: Cannot be added.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Check")]
        [Validation(Required=false)]
        public bool? Check { get; set; }

        /// <summary>
        /// <para>The result description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project name pass the check</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The real-time log project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_waf_userAccount_log</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34DCBC8A-<b><b>-</b></b>-****-6DAA11D7DDBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
