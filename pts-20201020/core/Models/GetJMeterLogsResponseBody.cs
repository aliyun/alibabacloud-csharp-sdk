// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of engines. The AgentCount value must be greater than the PageNumber value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AgentCount")]
        [Validation(Required=false)]
        public int? AgentCount { get; set; }

        /// <summary>
        /// <para>The system status code. If the request was successful, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;timeTS&quot;:1637114804326, &quot;instanceId&quot;:0, &quot;level&quot;:&quot;INFO&quot;, &quot;logger&quot;:&quot;org.apache.jmeter.util.JMeterUtils&quot;, &quot;sceneId&quot;:251546, 	&quot;planId&quot;:1501546, &quot;thread&quot;:&quot;main&quot;, &quot;time&quot;:&quot;2021-11-17T10:06Z&quot;, &quot;taskId&quot;:15015460000, &quot;logText&quot;:&quot;Setting Locale to en_EN\n&quot; }</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Logs { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, this parameter is left empty.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E16480-15C1-555A-922F-B736A005E52D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
