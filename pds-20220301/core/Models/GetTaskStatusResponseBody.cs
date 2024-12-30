// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The state of the task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>running</para>
        /// <!-- -->
        /// 
        /// <para>: The task is</para>
        /// <!-- -->
        /// 
        /// <para>running</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>failed</para>
        /// <!-- -->
        /// 
        /// <para>: The task</para>
        /// <!-- -->
        /// 
        /// <para>fails</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>succeeded</para>
        /// <!-- -->
        /// 
        /// <para>: The task is</para>
        /// <!-- -->
        /// 
        /// <para>successful</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
