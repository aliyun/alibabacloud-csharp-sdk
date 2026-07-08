// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class SendRenderingInstanceCommandsRequest : TeaModel {
        /// <summary>
        /// <para>A shell command string. Enter multiple commands separated by semicolons (;) or line feeds.</para>
        /// <list type="bullet">
        /// <item><description>Dangerous commands such as rm and reboot are disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>date;ls -l /tmp</para>
        /// </summary>
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public string Commands { get; set; }

        /// <summary>
        /// <para>The response pattern for the command. Valid values:</para>
        /// <ol>
        /// <item><description><para>Sync: The response is returned synchronously. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>Async: The response is returned asynchronously.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>Async</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The ID of the cloud application service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>The timeout period for command execution, in seconds. The value range depends on the Mode parameter:</para>
        /// <ol>
        /// <item><description><para>If Mode is set to Sync, the value range is 0 to 30. The default value is 30.</para>
        /// </description></item>
        /// <item><description><para>If Mode is set to Async, the value range is 0 to 3600. The default value is 300.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
