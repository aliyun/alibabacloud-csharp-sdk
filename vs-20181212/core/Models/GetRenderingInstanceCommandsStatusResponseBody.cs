// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class GetRenderingInstanceCommandsStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Description. When Status=Failed, this field contains the failure reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conn failed!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Command execution result string</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thu Jun 27 16:06:26 CST 2024</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>Command execution status. Valid values:</para>
        /// <ol>
        /// <item><description><para>Doing: Executing</para>
        /// </description></item>
        /// <item><description><para>Success: Succeeded</para>
        /// </description></item>
        /// <item><description><para>Failed: Failed. The system automatically retries within the timeout period. You can either wait or resend the request.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
