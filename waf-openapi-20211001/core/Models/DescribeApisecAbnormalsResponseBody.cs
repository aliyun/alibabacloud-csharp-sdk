// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAbnormalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of security risks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecAbnormalsResponseBodyData> Data { get; set; }
        public class DescribeApisecAbnormalsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of risk events that are associated with the security risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AbnormalEventNumber")]
            [Validation(Required=false)]
            public long? AbnormalEventNumber { get; set; }

            /// <summary>
            /// <para>The ID of the security risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c1431f27ae7e9c8cc64095***68e</para>
            /// </summary>
            [NameInMap("AbnormalId")]
            [Validation(Required=false)]
            public string AbnormalId { get; set; }

            /// <summary>
            /// <para>The details of the security risk in JSON format. The JSON object contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>rule</b>: The detection rule that triggered the security risk.</para>
            /// </description></item>
            /// <item><description><para><b>data_type</b>: The type of sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>custom_rule_name</b>: The name of the custom rule.</para>
            /// </description></item>
            /// <item><description><para><b>rule_name</b>: The name of the built-in rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;data_type&quot;: [&quot;1005&quot;,&quot;1004&quot;],
            ///     &quot;rule&quot;: {
            ///         &quot;parent&quot;: &quot;RiskType_Permission&quot;,
            ///         &quot;code&quot;: &quot;Risk_UnauthSensitive&quot;,
            ///         &quot;level&quot;: &quot;high&quot;,
            ///         &quot;origin&quot;: &quot;default&quot;,
            ///         &quot;name&quot;: &quot;Risk_UnauthSensitive&quot;
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("AbnormalInfo")]
            [Validation(Required=false)]
            public string AbnormalInfo { get; set; }

            /// <summary>
            /// <para>The severity level of the security risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>high</b>: High.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: Medium.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: Low.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("AbnormalLevel")]
            [Validation(Required=false)]
            public string AbnormalLevel { get; set; }

            /// <summary>
            /// <para>The type of the security risk.</para>
            /// <remarks>
            /// <para>Call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to query the supported risk types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>LackOfSpeedLimit</para>
            /// </summary>
            [NameInMap("AbnormalTag")]
            [Validation(Required=false)]
            public string AbnormalTag { get; set; }

            /// <summary>
            /// <para>The processing status of the security risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>unresolved</para>
            /// </summary>
            [NameInMap("AbnromalStatus")]
            [Validation(Required=false)]
            public string AbnromalStatus { get; set; }

            /// <summary>
            /// <para>The path of the API that is associated with the security risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/login</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API that is associated with the security risk.</para>
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
            /// <para>Call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to query the supported business purposes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SendMail</para>
            /// </summary>
            [NameInMap("ApiTag")]
            [Validation(Required=false)]
            public string ApiTag { get; set; }

            /// <summary>
            /// <para>The time when the security risk was first detected. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("DiscoverTime")]
            [Validation(Required=false)]
            public long? DiscoverTime { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The list of security risk samples.</para>
            /// </summary>
            [NameInMap("Examples")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> Examples { get; set; }

            /// <summary>
            /// <para>The time when the API was first discovered. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1701138088</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the security risk is being followed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: The security risk is being followed.</para>
            /// </description></item>
            /// <item><description><para><b>0</b> (default): The security risk is not being followed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public long? Follow { get; set; }

            /// <summary>
            /// <para>The time when the security risk was marked as ignored. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("IgnoreTime")]
            [Validation(Required=false)]
            public long? IgnoreTime { get; set; }

            /// <summary>
            /// <para>The most recent time when the API was accessed. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("LastestTime")]
            [Validation(Required=false)]
            public long? LastestTime { get; set; }

            /// <summary>
            /// <para>The most recent time when the security risk was detected. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("LatestDiscoverTime")]
            [Validation(Required=false)]
            public long? LatestDiscoverTime { get; set; }

            /// <summary>
            /// <para>The domain name or IP address that the API resides on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.aliyun.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The remarks for the security risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Strict</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The source of the risk detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>custom</b>: Custom rule.</para>
            /// </description></item>
            /// <item><description><para><b>default</b>: Built-in rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The handling status of the security risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>toBeConfirmed</b>: To be confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>confirmed</b>: Confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>toBeFixed</b>: To be fixed.</para>
            /// </description></item>
            /// <item><description><para><b>fixed</b>: Fixed (manually verified).</para>
            /// </description></item>
            /// <item><description><para><b>ignored</b>: Ignored.</para>
            /// </description></item>
            /// <item><description><para><b>toBeVerified</b>: To be verified by the system.</para>
            /// </description></item>
            /// <item><description><para><b>notFixed</b>: Verification failed.</para>
            /// </description></item>
            /// <item><description><para><b>systemFixed</b>: Fixed (verified by the system).</para>
            /// </description></item>
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
        /// <para>The total number of security risks returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
