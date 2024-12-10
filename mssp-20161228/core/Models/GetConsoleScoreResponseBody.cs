// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetConsoleScoreResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;score&quot;: &quot;94.00&quot;,
        ///     &quot;consoleScoreTrendDTOS&quot;: [
        ///         {
        ///             &quot;date&quot;: &quot;20241009&quot;,
        ///             &quot;score&quot;: &quot;100.0&quot;
        ///         }
        ///     ],
        ///     &quot;cyclicYearOverYear&quot;: &quot;-6.00&quot;,
        ///     &quot;recordDate&quot;: &quot;20241209&quot;,
        ///     &quot;weeklyYearOverYear&quot;: &quot;1.62&quot;,
        ///     &quot;aboveWholeNetworkUserRatio&quot;: &quot;6.25&quot;,
        ///     &quot;aliUid&quot;: &quot;1601097845544644&quot;,
        ///     &quot;detailJson&quot;: &quot;[{\&quot;detailDTO\&quot;:[{\&quot;count\&quot;:0,\&quot;itemName\&quot;:\&quot;应用漏洞POC验证\&quot;,\&quot;mark\&quot;:\&quot;1\&quot;},{\&quot;count\&quot;:0,\&quot;itemName\&quot;:\&quot;未授权访问漏洞（公网暴露）\&quot;,\&quot;mark\&quot;:\&quot;1\&quot;},{\&quot;count\&quot;:0,\&quot;itemName\&quot;:\&quot;后台弱口令漏洞（公网暴露）\&quot;,\&quot;mark\&quot;:\&quot;1\&quot;},{\&quot;count\&quot;:0,\&quot;itemName\&quot;:\&quot;文件上传漏洞（公网暴露）\&quot;,\&quot;mark\&quot;:\&quot;1\&quot;}],\&quot;markRate\&quot;:\&quot;0.5\&quot;,\&quot;markType\&quot;:\&quot;vul\&quot;},{\&quot;detailDTO\&quot;:[{\&quot;count\&quot;:12,\&quot;itemName\&quot;:\&quot;WAF3.0回源配置不正确\&quot;,\&quot;mark\&quot;:\&quot;1\&quot;},{\&quot;count\&quot;:0,\&quot;itemName\&quot;:\&quot;AK泄露检查未开启\&quot;,\&quot;mark\&quot;:\&quot;1\&quot;},{\&quot;count\&quot;:0,\&quot;itemName\&quot;:\&quot;DNAT管理端口开放\&quot;,\&quot;mark\&quot;:\&quot;1\&quot;},{\&quot;count\&quot;:0,\&quot;itemName\&quot;:\&quot;高危端口暴露\&quot;,\&quot;mark\&quot;:\&quot;0.5\&quot;}],\&quot;markRate\&quot;:\&quot;0.5\&quot;,\&quot;markType\&quot;:\&quot;risk\&quot;}]&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Prompt message for the result returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0937B0F-9180-5F70-B6ED-0BA22591627F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. true means success, false means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
