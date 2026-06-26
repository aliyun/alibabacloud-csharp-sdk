// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class SilenceTimeoutResponseBody : TeaModel {
        /// <summary>
        /// <para>The system\&quot;s next action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TransferToAgent</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>Parameters for the action defined in the Action parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;skillGroupId&quot;: &quot;ABC&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>Indicates whether the action is interruptible.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Interruptible")]
        [Validation(Required=false)]
        public bool? Interruptible { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The text response to play to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>正在为你转接人工坐席</para>
        /// </summary>
        [NameInMap("TextResponse")]
        [Validation(Required=false)]
        public string TextResponse { get; set; }

    }

}
