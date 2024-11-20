// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateAuditRequest : TeaModel {
        /// <summary>
        /// <para>The review results. You can specify the results for a maximum of 20 videos at a time. The value must be converted to a string. For more information about the parameters in AuditContent, see the &quot;AuditContent&quot; section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;MediaId&quot;: &quot;93ab850b4f<em><b><b>b54b6e91d24d81d4&quot;,
        ///             &quot;Status&quot;: &quot;Normal&quot;
        ///       },
        ///       {
        ///             &quot;MediaId&quot;: &quot;f867fbfb58</b></b></em>8bbab65c4480ae1d&quot;,
        ///             &quot;Status&quot;: &quot;Blocked&quot;,
        ///             &quot;Reason&quot;: &quot;xxxx&quot;,
        ///             &quot;Comment&quot;: &quot;xxxx&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("AuditContent")]
        [Validation(Required=false)]
        public string AuditContent { get; set; }

    }

}
