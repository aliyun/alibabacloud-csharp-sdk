// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StopAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The message returned when the execution fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The execution result status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: The execution is successful.</description></item>
        /// <item><description>False: The execution failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
