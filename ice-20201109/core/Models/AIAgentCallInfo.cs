// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentCallInfo : TeaModel {
        /// <summary>
        /// <para>The duration of the call, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("CallDuration")]
        [Validation(Required=false)]
        public int? CallDuration { get; set; }

        /// <summary>
        /// <para>The time the call ended, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-01T16:53:58.875932+00:00</para>
        /// </summary>
        [NameInMap("CallEndTime")]
        [Validation(Required=false)]
        public string CallEndTime { get; set; }

        /// <summary>
        /// <para>The time the call started, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-01T16:53:53.184797+00:00</para>
        /// </summary>
        [NameInMap("CallStartTime")]
        [Validation(Required=false)]
        public string CallStartTime { get; set; }

        /// <summary>
        /// <para>The number of the called party.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136******794</para>
        /// </summary>
        [NameInMap("CalleeNumber")]
        [Validation(Required=false)]
        public string CalleeNumber { get; set; }

        /// <summary>
        /// <para>The number of the calling party.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183*****333</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <para>Indicates which party ended the call.
        /// 0: The agent ended the call.
        /// 1: The user ended the call.
        /// 2: The system ended the call for a transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HangupRole")]
        [Validation(Required=false)]
        public int? HangupRole { get; set; }

        /// <summary>
        /// <para>The status of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
