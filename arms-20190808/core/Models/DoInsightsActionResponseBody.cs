// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DoInsightsActionResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. 200 means success, other status codes are exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters vary with the value of module.</para>
        /// <list type="bullet">
        /// <item><description><para>QueryTopo</para>
        /// <pre><c>{
        ///  &quot;nodes&quot;: [Node] # The collection of nodes. For more information, see the &quot;Node&quot; section of this topic.
        ///  &quot;edges&quot;: [Edge] # The collection of edges. For more information, see the &quot;Edge&quot; section of this topic.
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>QueryTopoRed</para>
        /// <pre><c>{
        ///   &quot;nodeRed&quot;: {
        ///       &quot;nodeId&quot;: {
        ///           &quot;count&quot;: double, # The total number of requests in the specified time range.
        ///           &quot;error&quot;: double, # The total number of errors in the specified time range.
        ///           &quot;rt&quot;: double, # The average response time in the specified time range. Unit: milliseconds.
        ///       }
        ///   },
        ///   &quot;edgeRed&quot;: {
        ///       &quot;edgeId&quot;: {
        ///           &quot;count&quot;: double, # The total number of requests in the specified time range.
        ///           &quot;error&quot;: double, # The total number of errors in the specified time range.
        ///           &quot;rt&quot;: double, # The average response time in the specified time range. Unit: milliseconds.
        ///       }
        ///   }
        /// </c></pre>
        /// </description></item>
        /// </list>
        /// <para>}</para>
        /// <pre><c>
        /// </c></pre>
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
        /// <para>Information returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
