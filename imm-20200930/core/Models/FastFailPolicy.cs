// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FastFailPolicy : TeaModel {
        /// <summary>
        /// <para>The action when the batch processor or trigger encounters an error.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>abort: stops running.</description></item>
        /// <item><description>ignore: ignores the error and keeps running.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abort</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

    }

}
