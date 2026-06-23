// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateContactGroupForAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The message returned when the operation failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>contact group illegal.</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The status of the update result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The operation is successful.</description></item>
        /// <item><description>false: The operation failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
