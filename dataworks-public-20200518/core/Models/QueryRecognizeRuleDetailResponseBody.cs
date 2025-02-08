// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryRecognizeRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the sensitive field in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nodeName&quot;:&quot;basic unit overview&quot;,&quot;gmtModified&quot;:1709017449000,&quot;hitThreshold&quot;:30,&quot;sensitiveName&quot;:&quot;mobile-yinni&quot;,&quot;templateId&quot;:&quot;8222abeb-9784-4417-b420-0322926d5cbf&quot;,&quot;recognizeRulesType&quot;:2,&quot;delete&quot;:false,&quot;bydAccuracy&quot;:1,&quot;colScan&quot;:&quot;,&quot; defineType &quot;:1,&quot;: ydAccuracy &quot;:{&quot; contentRule &quot;:)),&quot; operationType &quot;:0},&quot; nodeParent &quot;:&quot; unit/unit basic information/unit basic overview &quot;,&quot; level &quot;:6,&quot; keyRuleId &quot;:&quot; 228248921215042mobile-yinni &quot;,&quot; isDelete &quot;:false,&quot; levelName &quot;:&quot; 6level &quot;,&quot; sensitive &quot;:false,&quot; operationType &quot;:0,&quot; sourceName &quot;: dsg-test-zuoyue&quot;,&quot;nodeId&quot;:&quot;bea2fc81-90c9-45f3-b7a9-26d534208a0d&quot;,&quot;status&quot;:1}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9990030003</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Missing parameter</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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
