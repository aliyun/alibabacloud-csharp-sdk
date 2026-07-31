// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of attacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>345</para>
        /// </summary>
        [NameInMap("AttackCnt")]
        [Validation(Required=false)]
        public string AttackCnt { get; set; }

        /// <summary>
        /// <para>The attacker list.</para>
        /// </summary>
        [NameInMap("AttackerList")]
        [Validation(Required=false)]
        public List<string> AttackerList { get; set; }

        /// <summary>
        /// <para>The detailed information about the security event. The value is a string converted from a JSON object constructed by a series of parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;location\&quot;:[\&quot;FR\&quot;,\&quot;CN\&quot;],\&quot;location_type\&quot;:\&quot;country\&quot;}</para>
        /// </summary>
        [NameInMap("DetailValue")]
        [Validation(Required=false)]
        public string DetailValue { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683703260</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public string EndTs { get; set; }

        /// <summary>
        /// <para>The ID of the API security event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18ba94fea9***e66ba0557b7b91</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The event level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b>: high risk.</description></item>
        /// <item><description><b>medium</b>: medium risk.</description></item>
        /// <item><description><b>low</b>: low risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The dimension of the security event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ip</b> (default): IP security event.</para>
        /// </description></item>
        /// <item><description><para><b>account</b>: account security event.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EventScope")]
        [Validation(Required=false)]
        public string EventScope { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported event types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ObtainSensitiveUnauthorized</para>
        /// </summary>
        [NameInMap("EventTag")]
        [Validation(Required=false)]
        public string EventTag { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>already confirmed.</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The origin of the event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: custom.</description></item>
        /// <item><description><b>default</b>: built-in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683648000</para>
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public string StartTs { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>toBeConfirmed</b>: to be confirmed.</description></item>
        /// <item><description><b>confirmed</b>: confirmed.</description></item>
        /// <item><description><b>actioned</b>: handled.</description></item>
        /// <item><description><b>ignored</b>: ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>toBeConfirmed</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
