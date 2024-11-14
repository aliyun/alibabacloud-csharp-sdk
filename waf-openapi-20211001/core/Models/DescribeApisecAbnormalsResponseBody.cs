// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAbnormalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The risks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecAbnormalsResponseBodyData> Data { get; set; }
        public class DescribeApisecAbnormalsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of risk-related security events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AbnormalEventNumber")]
            [Validation(Required=false)]
            public long? AbnormalEventNumber { get; set; }

            /// <summary>
            /// <para>The ID of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c1431f27ae7e9c8cc64095***68e</para>
            /// </summary>
            [NameInMap("AbnormalId")]
            [Validation(Required=false)]
            public string AbnormalId { get; set; }

            /// <summary>
            /// <para>The details of the risk. The value is a string that consists of multiple parameters in the JSON format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>rule</b>: risk-related rule</description></item>
            /// <item><description><b>data_type</b>: sensitive data type</description></item>
            /// <item><description><b>custom_rule_name</b>: custom rule name</description></item>
            /// <item><description><b>rule_name</b>: built-in rule name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;data_type&quot;: [&quot;1005&quot;,&quot;1004&quot;], &quot;rule&quot;: { &quot;parent&quot;: &quot;RiskType_Permission&quot;, &quot;code&quot;: &quot;Risk_UnauthSensitive&quot;, &quot;level&quot;: &quot;high&quot;, &quot;origin&quot;: &quot;default&quot;, &quot;name&quot;: &quot;Risk_UnauthSensitive&quot; } }</para>
            /// </summary>
            [NameInMap("AbnormalInfo")]
            [Validation(Required=false)]
            public string AbnormalInfo { get; set; }

            /// <summary>
            /// <para>The level of the risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("AbnormalLevel")]
            [Validation(Required=false)]
            public string AbnormalLevel { get; set; }

            /// <summary>
            /// <para>The type of the risk.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeApisecRules~~">DescribeApisecRules</a> operation to query the supported types of risks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>LackOfSpeedLimit</para>
            /// </summary>
            [NameInMap("AbnormalTag")]
            [Validation(Required=false)]
            public string AbnormalTag { get; set; }

            /// <summary>
            /// <para>The status of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>unresolved</para>
            /// </summary>
            [NameInMap("AbnromalStatus")]
            [Validation(Required=false)]
            public string AbnromalStatus { get; set; }

            /// <summary>
            /// <para>The risk-related API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/login</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the risk-related API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09559c0d71ca2ffc996b81***836d8</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The business purpose of the API.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeApisecRules~~">DescribeApisecRules</a> operation to query the business purposes of APIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SendMail</para>
            /// </summary>
            [NameInMap("ApiTag")]
            [Validation(Required=false)]
            public string ApiTag { get; set; }

            /// <summary>
            /// <para>The time at which the risk was detected. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("DiscoverTime")]
            [Validation(Required=false)]
            public long? DiscoverTime { get; set; }

            /// <summary>
            /// <para>The risk-related samples.</para>
            /// </summary>
            [NameInMap("Examples")]
            [Validation(Required=false)]
            public List<string> Examples { get; set; }

            /// <summary>
            /// <para>The time at which the risk was first detected. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1701138088</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the API is followed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>(default): no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public long? Follow { get; set; }

            /// <summary>
            /// <para>The time at which the risk was marked as ignored. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("IgnoreTime")]
            [Validation(Required=false)]
            public long? IgnoreTime { get; set; }

            /// <summary>
            /// <para>The time at which the risk was last active. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("LastestTime")]
            [Validation(Required=false)]
            public long? LastestTime { get; set; }

            /// <summary>
            /// <para>The domain name or IP address of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.aliyun.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business side notified</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The source of the risk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>custom</b></description></item>
            /// <item><description><b>default</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The status of the risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>toBeConfirmed</b></description></item>
            /// <item><description><b>confirmed</b></description></item>
            /// <item><description><b>toBeFixed</b></description></item>
            /// <item><description><b>fixed</b></description></item>
            /// <item><description><b>ignored</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Confirmed</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9469646C-F2CC-5F0F-8401-C53***4F46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
