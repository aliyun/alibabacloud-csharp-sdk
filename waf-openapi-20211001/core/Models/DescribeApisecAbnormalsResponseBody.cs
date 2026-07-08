// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAbnormalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of risks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecAbnormalsResponseBodyData> Data { get; set; }
        public class DescribeApisecAbnormalsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of events associated with the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AbnormalEventNumber")]
            [Validation(Required=false)]
            public long? AbnormalEventNumber { get; set; }

            /// <summary>
            /// <para>The risk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c1431f27ae7e9c8cc64095***68e</para>
            /// </summary>
            [NameInMap("AbnormalId")]
            [Validation(Required=false)]
            public string AbnormalId { get; set; }

            /// <summary>
            /// <para>The detailed risk information, which is a JSON string constructed from a series of parameters. The parameters include:</para>
            /// <list type="bullet">
            /// <item><description><b>rule</b>: the rule associated with the risk.</description></item>
            /// <item><description><b>data_type</b>: the sensitive data type.</description></item>
            /// <item><description><b>custom_rule_name</b>: the custom rule name.</description></item>
            /// <item><description><b>rule_name</b>: the built-in rule name.</description></item>
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
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b>: high risk.</description></item>
            /// <item><description><b>medium</b>: medium risk.</description></item>
            /// <item><description><b>low</b>: low risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("AbnormalLevel")]
            [Validation(Required=false)]
            public string AbnormalLevel { get; set; }

            /// <summary>
            /// <para>The risk type.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported risk types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>LackOfSpeedLimit</para>
            /// </summary>
            [NameInMap("AbnormalTag")]
            [Validation(Required=false)]
            public string AbnormalTag { get; set; }

            /// <summary>
            /// <para>The risk status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>unresolved</para>
            /// </summary>
            [NameInMap("AbnromalStatus")]
            [Validation(Required=false)]
            public string AbnromalStatus { get; set; }

            /// <summary>
            /// <para>The API operation associated with the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/login</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API associated with the risk.</para>
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
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported business purposes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SendMail</para>
            /// </summary>
            [NameInMap("ApiTag")]
            [Validation(Required=false)]
            public string ApiTag { get; set; }

            /// <summary>
            /// <para>The time when the risk was first detected. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
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
            /// <para>The list of examples associated with the risk.</para>
            /// </summary>
            [NameInMap("Examples")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> Examples { get; set; }

            /// <summary>
            /// <para>The time when the API asset was first discovered. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1701138088</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the risk is followed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: followed.</description></item>
            /// <item><description><b>0</b>: not followed. This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public long? Follow { get; set; }

            /// <summary>
            /// <para>The time when the user marked the risk as ignored. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("IgnoreTime")]
            [Validation(Required=false)]
            public long? IgnoreTime { get; set; }

            /// <summary>
            /// <para>The most recent access time of the API asset. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("LastestTime")]
            [Validation(Required=false)]
            public long? LastestTime { get; set; }

            /// <summary>
            /// <para>The time when the risk was most recently detected. The value is a UNIX timestamp (UTC). Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684252800</para>
            /// </summary>
            [NameInMap("LatestDiscoverTime")]
            [Validation(Required=false)]
            public long? LatestDiscoverTime { get; set; }

            /// <summary>
            /// <para>The domain name or IP address to which the API operation belongs.</para>
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
            /// <para>Strict</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The source of the risk type. Valid values:</para>
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
            /// <para>The risk status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>toBeConfirmed</b>: to be confirmed.</description></item>
            /// <item><description><b>confirmed</b>: confirmed.</description></item>
            /// <item><description><b>toBeFixed</b>: to be fixed.</description></item>
            /// <item><description><b>fixed</b>: fixed (manually verified).</description></item>
            /// <item><description><b>ignored</b>: ignored.</description></item>
            /// <item><description>** toBeVerified**: to be verified by the system.</description></item>
            /// <item><description>** notFixed**: not fixed after verification.</description></item>
            /// <item><description>** systemFixed**: fixed (verified by the system).</description></item>
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
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
