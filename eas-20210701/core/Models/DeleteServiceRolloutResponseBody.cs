// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceRolloutResponseBody : TeaModel {
        /// <summary>
        /// <para>A message indicating the result of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>Type: <c>string</c></para>
        /// </description></item>
        /// <item><description><para>Description: The message that describes the result of the request.</para>
        /// </description></item>
        /// <item><description><para>Example value: <c>Rollout deleted successfully</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Rollout deleted successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Use this ID for troubleshooting.</para>
        /// <list type="bullet">
        /// <item><description><para>Type: <c>string</c></para>
        /// </description></item>
        /// <item><description><para>Description: The unique identifier for the request. Use this ID to troubleshoot and track issues.</para>
        /// </description></item>
        /// <item><description><para>Example: <c>40325405-579C-4D82-9B4F-8A7C6D5E4F3A</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
