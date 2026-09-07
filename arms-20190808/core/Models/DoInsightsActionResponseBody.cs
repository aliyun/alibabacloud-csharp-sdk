// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DoInsightsActionResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. 200 indicates success; other status codes indicate exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return parameter type is related to the module value passed in.</para>
        /// <list type="bullet">
        /// <item><description><para>QueryTopo</para>
        /// <pre><c>{
        ///  &quot;nodes&quot;: [Object] #Node collection. See the Node definition in the supplementary description of return parameters.
        ///  &quot;edges&quot;: [Object] #Edge collection. See the Edge definition in the supplementary description of return parameters.
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>QueryTopoRed</para>
        /// <pre><c>{
        ///   &quot;nodeRed&quot;: {
        ///       &quot;nodeId&quot;: {
        ///           &quot;count&quot;: double, #Total number of requests during the query period
        ///           &quot;error&quot;: double, #Total number of errors during the query period
        ///           &quot;rt&quot;: double, #Average latency during the query period, in milliseconds
        ///       }
        ///   },
        ///   &quot;edgeRed&quot;: {
        ///       &quot;edgeId&quot;: {
        ///           &quot;count&quot;: double, #Total number of requests during the query period
        ///           &quot;error&quot;: double, #Total number of errors during the query period
        ///           &quot;rt&quot;: double, #Average latency during the query period, in milliseconds
        ///       }
        ///   }
        /// </c></pre>
        /// </description></item>
        /// </list>
        /// <para>}
        ///   ```</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description><para>QueryTopo</para>
        /// <para>  {
        ///   &quot;nodes&quot;: [
        ///       {
        ///           &quot;nodeId&quot;: &quot;3bfe1a747389273388182760406c079d&quot;,
        ///           &quot;entity&quot;: {
        ///               &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
        ///               &quot;appType&quot;: &quot;TRACE&quot;,
        ///               &quot;appId&quot;: &quot;xxxxxxxxxxxxxxxx&quot;,
        ///               &quot;name&quot;: &quot;prometheus-pop-cn-hangzhou&quot;,
        ///               &quot;entityId&quot;: &quot;3bfe1a747389273388182760406c079d&quot;,
        ///               &quot;firstSeenTms&quot;: 1721733226981,
        ///               &quot;lastSeenTms&quot;: 1721789171614,
        ///               &quot;type&quot;: &quot;APPLICATION&quot;
        ///           },
        ///           &quot;attrs&quot;: {
        ///               &quot;RED&quot;: {
        ///                   &quot;count&quot;: 643848.0,
        ///                   &quot;error&quot;: 0.0,
        ///                   &quot;rt&quot;: 172.31701892372112
        ///               }
        ///           }
        ///       }
        ///   ],
        ///   &quot;edges&quot;: [
        ///       {
        ///           &quot;from&quot;: &quot;98b4184b22e588cf86e9a29aa4179606&quot;,
        ///           &quot;to&quot;: &quot;98b4184b22e588cf86e9a29aa4179606&quot;,
        ///           &quot;type&quot;: &quot;CALLS&quot;,
        ///           &quot;attrs&quot;: {
        ///               &quot;RED&quot;: {
        ///                   &quot;count&quot;: 4.0,
        ///                   &quot;error&quot;: 0.0,
        ///                   &quot;rt&quot;: 37.0
        ///               }
        ///           },
        ///           &quot;edgeId&quot;: &quot;5d611597e4b0013d0947615c9eca4de6&quot;,
        ///           &quot;firstSeenTms&quot;: 1721783795125,
        ///           &quot;lastSeenTms&quot;: 1721787371614
        ///       }
        ///   ]
        ///   }</para>
        /// </description></item>
        /// <item><description><para>QueryTopoRed</para>
        /// <para>  {
        ///   &quot;nodeRed&quot;: {
        ///       &quot;361d9f32e58cef316bf2355f3ff05575&quot;: {
        ///           &quot;count&quot;: 3258110.0,
        ///           &quot;error&quot;: 74.0,
        ///           &quot;rt&quot;: 167.39844355494878
        ///       }
        ///   },
        ///   &quot;edgeRed&quot;: {}
        ///   }</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>626037F5-FDEB-45B0-804C-B3C92797A64E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the query is successful:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Successful.</description></item>
        /// <item><description><c>false</c>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
