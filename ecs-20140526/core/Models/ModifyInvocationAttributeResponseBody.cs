// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInvocationAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The command ID.</para>
        /// <list type="bullet">
        /// <item><description>A new command is created and the new <c>CommandId</c> is returned only when <c>CommandContent</c> is changed.</description></item>
        /// <item><description>If <c>CommandContent</c> is not changed, no new command is created, and the <c>CommandId</c> of the currently executed command is returned.</description></item>
        /// <item><description>If you call <a href="https://help.aliyun.com/document_detail/64841.html">InvokeCommand</a> or set <c>KeepCommand</c> to <c>true</c> when you call <a href="https://help.aliyun.com/document_detail/141751.html">RunCommand</a>, the new command is retained. Otherwise, all commands associated with the task are deleted when the task is completed or manually stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz01272yr52****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
