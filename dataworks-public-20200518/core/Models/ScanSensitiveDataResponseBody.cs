// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ScanSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The check result. sensDatas indicates the rules that are used to check the sensitive data. sensDatas includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>hitCount: the number of times that the sensitive data hits the rule.</description></item>
        /// <item><description>ruleName: the name of the rule.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Sensitives")]
        [Validation(Required=false)]
        public Dictionary<string, object> Sensitives { get; set; }

    }

}
