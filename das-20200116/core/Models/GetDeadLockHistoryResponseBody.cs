// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadLockHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned as a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para>total: The total number of deadlocks.</para>
        /// </description></item>
        /// <item><description><para>list: The list of deadlocks.</para>
        /// <list type="bullet">
        /// <item><description><para>accountId: The user ID.</para>
        /// </description></item>
        /// <item><description><para>textId: The text ID of the deadlock.</para>
        /// </description></item>
        /// <item><description><para>gmtModified: The time when the diagnostics were generated.</para>
        /// </description></item>
        /// <item><description><para>lockTime: The time when the deadlock occurred.</para>
        /// </description></item>
        /// <item><description><para>gmtCreate: The time when the diagnostics were created.</para>
        /// </description></item>
        /// <item><description><para>nodeId: The node ID.</para>
        /// </description></item>
        /// <item><description><para>uuid: The instance ID.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;total&quot;: 2,
        ///     &quot;list&quot;: [
        ///         {
        ///             &quot;accountId&quot;: &quot;108************&quot;,
        ///             &quot;textId&quot;: &quot;35303d12d52d29ba73bb85fa2d5b****&quot;,
        ///             &quot;gmtModified&quot;: 1732712680000,
        ///             &quot;lockTime&quot;: 1732687047000,
        ///             &quot;gmtCreate&quot;: 1732712680000,
        ///             &quot;nodeId&quot;: &quot;pi-8****************&quot;,
        ///             &quot;uuid&quot;: &quot;pc-8v**************&quot;
        ///         },
        ///         {
        ///             &quot;accountId&quot;: &quot;108************&quot;,
        ///             &quot;textId&quot;: &quot;50a24bdcc5fe7e03f92a55ae7574****&quot;,
        ///             &quot;gmtModified&quot;: 1732626448000,
        ///             &quot;lockTime&quot;: 1722500305000,
        ///             &quot;gmtCreate&quot;: 1732626448000,
        ///             &quot;nodeId&quot;: &quot;pi-8****************&quot;,
        ///             &quot;uuid&quot;: &quot;pc-8v**************&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public string Synchro { get; set; }

    }

}
