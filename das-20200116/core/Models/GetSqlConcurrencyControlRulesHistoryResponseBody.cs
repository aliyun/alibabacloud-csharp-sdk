// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetSqlConcurrencyControlRulesHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information, including the error codes and the number of entries that are returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSqlConcurrencyControlRulesHistoryResponseBodyData Data { get; set; }
        public class GetSqlConcurrencyControlRulesHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of the queried throttling rules.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetSqlConcurrencyControlRulesHistoryResponseBodyDataList List { get; set; }
            public class GetSqlConcurrencyControlRulesHistoryResponseBodyDataList : TeaModel {
                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<GetSqlConcurrencyControlRulesHistoryResponseBodyDataListRules> Rules { get; set; }
                public class GetSqlConcurrencyControlRulesHistoryResponseBodyDataListRules : TeaModel {
                    /// <summary>
                    /// <para>The duration within which the SQL throttling rule takes effect. Unit: seconds.</para>
                    /// <remarks>
                    /// <para> The throttling rule takes effect only within this duration.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("ConcurrencyControlTime")]
                    [Validation(Required=false)]
                    public long? ConcurrencyControlTime { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-2ze1jdv45i7l6****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The ID of the throttling rule that is applied to the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16</para>
                    /// </summary>
                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    /// <summary>
                    /// <para>The hash value of the SQL keywords. The SQL keywords are contained in the SQL statements to which the throttling rule is applied.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b0b8aceeb43baea87b219c81767b****</para>
                    /// </summary>
                    [NameInMap("KeywordsHash")]
                    [Validation(Required=false)]
                    public string KeywordsHash { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent SQL statements. Set this parameter to a positive integer.</para>
                    /// <remarks>
                    /// <para> When the number of concurrent SQL statements that contain the specified keywords reaches this upper limit, the throttling rule is triggered.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaxConcurrency")]
                    [Validation(Required=false)]
                    public long? MaxConcurrency { get; set; }

                    /// <summary>
                    /// <para>The keywords that are used to identify the SQL statements that need to be throttled.</para>
                    /// <remarks>
                    /// <para>SQL keywords are separated with tildes (~). When the number of concurrent SQL statements that contain all the specified SQL keywords reaches the specified upper limit, the throttling rule is triggered.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>call<del>open</del>api<del>test</del>4<del>from</del>POP</para>
                    /// </summary>
                    [NameInMap("SqlKeywords")]
                    [Validation(Required=false)]
                    public string SqlKeywords { get; set; }

                    /// <summary>
                    /// <para>The type of the SQL statements. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>SELECT</b></description></item>
                    /// <item><description><b>UPDATE</b></description></item>
                    /// <item><description><b>DELETE</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT</para>
                    /// </summary>
                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    /// <summary>
                    /// <para>The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1608888296000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The state of the throttling rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Open</b>: The throttling rule is in effect.</description></item>
                    /// <item><description><b>Closed</b>: The throttling rule was in effect.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Open</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testxxx</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
