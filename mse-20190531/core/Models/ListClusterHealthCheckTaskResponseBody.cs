// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListClusterHealthCheckTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 is returned if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListClusterHealthCheckTaskResponseBodyData Data { get; set; }
        public class ListClusterHealthCheckTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of health check tasks.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListClusterHealthCheckTaskResponseBodyDataResult> Result { get; set; }
            public class ListClusterHealthCheckTaskResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The complete version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.1</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PREPAY</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The type of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Nacos-Ans</para>
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-20T06:51:46Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>A redundant parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse_ingresspost-cn-0jbvrcex****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the user to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("PrimaryUser")]
                [Validation(Required=false)]
                public string PrimaryUser { get; set; }

                /// <summary>
                /// <para>The number of nodes in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Replica")]
                [Validation(Required=false)]
                public string Replica { get; set; }

                /// <summary>
                /// <para>The list of risk items.</para>
                /// </summary>
                [NameInMap("RiskList")]
                [Validation(Required=false)]
                public List<ListClusterHealthCheckTaskResponseBodyDataResultRiskList> RiskList { get; set; }
                public class ListClusterHealthCheckTaskResponseBodyDataResultRiskList : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\\&quot;desc\\&quot;:\\&quot;The engine version is outdated and a large number of features are not supported. Upgrade the engine to the latest version at the earliest opportunity. \\&quot;}</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DescriptionEn")]
                    [Validation(Required=false)]
                    public string DescriptionEn { get; set; }

                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3426</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// <para>A redundant parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public string Module { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the risk item notification feature is disabled.</para>
                    /// <list type="bullet">
                    /// <item><description>true: disabled</description></item>
                    /// <item><description>false: enabled</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Mute")]
                    [Validation(Required=false)]
                    public bool? Mute { get; set; }

                    /// <summary>
                    /// <para>A redundant parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("NoticeFeature")]
                    [Validation(Required=false)]
                    public bool? NoticeFeature { get; set; }

                    /// <summary>
                    /// <para>The ID of the user to which the cluster belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("PrimaryUser")]
                    [Validation(Required=false)]
                    public string PrimaryUser { get; set; }

                    /// <summary>
                    /// <para>The risk code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22020010001</para>
                    /// </summary>
                    [NameInMap("RiskCode")]
                    [Validation(Required=false)]
                    public string RiskCode { get; set; }

                    /// <summary>
                    /// <para>The severity of the risk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HIGH: high risk</description></item>
                    /// <item><description>MID: medium risk</description></item>
                    /// <item><description>LOW: low risk</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MID</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The name of the risk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The engine version is outdated.</para>
                    /// </summary>
                    [NameInMap("RiskName")]
                    [Validation(Required=false)]
                    public string RiskName { get; set; }

                    [NameInMap("RiskNameEn")]
                    [Validation(Required=false)]
                    public string RiskNameEn { get; set; }

                    /// <summary>
                    /// <para>The type of the risk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Version risk</para>
                    /// </summary>
                    [NameInMap("RiskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                    /// <summary>
                    /// <para>The situation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\\&quot;desc\\&quot;:\\&quot;The engine version is outdated and a large number of features are not supported.\\&quot;,\\&quot;links\\&quot;:[{\\&quot;type\\&quot;:\\&quot;url\\&quot;,\\&quot;value\\&quot;:\\&quot;<a href="https://xxxx%22%5C%5C%5C%5C%22,%5C%5C%5C%5C%22desc%5C%5C%5C%5C%22:%5C%5C%5C%5C%22Release">https://xxxx&quot;\\\\&quot;,\\\\&quot;desc\\\\&quot;:\\\\&quot;Release</a> notes\\&quot;}]}</para>
                    /// </summary>
                    [NameInMap("Situation")]
                    [Validation(Required=false)]
                    public string Situation { get; set; }

                    [NameInMap("SituationEn")]
                    [Validation(Required=false)]
                    public string SituationEn { get; set; }

                    /// <summary>
                    /// <para>The suggestion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;desc&quot;: &quot;Upgrade to the latest version at the earliest opportunity.&quot;, &quot;links&quot;:[{&quot;type&quot;: &quot;upgrade&quot;, &quot;desc&quot;: &quot;Click to upgrade&quot;}]}</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("SuggestionEn")]
                    [Validation(Required=false)]
                    public string SuggestionEn { get; set; }

                    /// <summary>
                    /// <para>The ID of the associated parent task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    /// <summary>
                    /// <para>A redundant parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>A redundant parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                /// <summary>
                /// <para>The total score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE_SC_2_4_200_c</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The status of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISH</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The total number of check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalItem")]
                [Validation(Required=false)]
                public int? TotalItem { get; set; }

                /// <summary>
                /// <para>The total number of risk items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalRisk")]
                [Validation(Required=false)]
                public int? TotalRisk { get; set; }

                /// <summary>
                /// <para>A redundant parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The last update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-12 15:07:55</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NACOS_ANS_1_2_1_3</para>
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The dynamic part in the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace the \<em>\</em>%s\<em>\</em> variable in the <b>ErrMessage</b> parameter.</para>
        /// <remarks>
        /// <para>If the return value of the <b>ErrMessage</b> parameter is <b>The Value of Input Parameter %s is not valid</b> and the return value of the <b>DynamicMessage</b> parameter is <b>DtsJobId</b>, the specified <b>DtsJobId</b> parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned if the request is successful.</description></item>
        /// <item><description>The <b>ErrorCode</b> parameter is returned if the request fails. For more information, see the <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request was successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E9FDCFE-0738-493B-B801-82BDFBCB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
