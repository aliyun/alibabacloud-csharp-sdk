// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HangupOperateRequest : TeaModel {
        /// <summary>
        /// <para>The call ID. Obtain this ID from the response of the <a href="https://help.aliyun.com/document_detail/2862828.html">LlmSmartCall</a> or <a href="https://help.aliyun.com/document_detail/2881065.html">LlmSmartCallEncrypt</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14777672<b><b>^13452272</b></b></para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>Specifies whether to hang up the call immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Hangs up the call immediately.</para>
        /// </description></item>
        /// <item><description><para>false: Hangs up the call after the current playback finishes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ImmediateHangup")]
        [Validation(Required=false)]
        public bool? ImmediateHangup { get; set; }

    }

}
