// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetMailTaskStatusRequest : TeaModel {
        /// <summary>
        /// <para>Mail ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d5a5<b><b>8b634d</b></b>5584f8dc159c62</para>
        /// </summary>
        [NameInMap("MailId")]
        [Validation(Required=false)]
        public string MailId { get; set; }

        /// <summary>
        /// <para>Task ID</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the task ID is not provided, the latest task status will be returned by default;</description></item>
        /// <item><description>If the task ID is provided, the status of the specified task will be returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7218<b><b>0392</b></b>212</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
