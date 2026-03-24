// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFreeUserEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of security events detected by the basic scan.</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public List<DescribeFreeUserEventsResponseBodyEvent> Event { get; set; }
        public class DescribeFreeUserEventsResponseBodyEvent : TeaModel {
            /// <summary>
            /// <para>The API path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/login</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The attack IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>104.234.140.**</para>
            /// </summary>
            [NameInMap("AttackIP")]
            [Validation(Required=false)]
            public string AttackIP { get; set; }

            /// <summary>
            /// <para>The time of the attack. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683703260</para>
            /// </summary>
            [NameInMap("AttackTime")]
            [Validation(Required=false)]
            public long? AttackTime { get; set; }

            /// <summary>
            /// <para>The domain name to which the API belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>www.***.cn</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The event level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>high</b>: high risk.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: medium risk.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: low risk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// <remarks>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to obtain the supported event types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Event_DataTraverse</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A2DF88D-90C2-56E9-B8D5-36BB9646791C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
