// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class SendRenderingInstanceCommandsResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the command request. The ID is valid for one day by default. In asynchronous scenarios, if you need the result, query it promptly within the validity period, preferably before the command times out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmd-81de027b66e442e99c1e0e09a16a0be5</para>
        /// </summary>
        [NameInMap("CmdId")]
        [Validation(Required=false)]
        public string CmdId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the command response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thu Jun 27 16:06:26 CST 2024</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
