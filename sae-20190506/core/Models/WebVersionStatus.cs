// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebVersionStatus : TeaModel {
        /// <summary>
        /// <para>The error message of the application execution. If the execution is successful, a null value is returned.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The state of the application execution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Completed</b>: The execution is successful.</description></item>
        /// <item><description><b>Updating</b>:The instance is being updated.</description></item>
        /// <item><description><b>Updating</b>:The execution failed and a non-null error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Completed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
