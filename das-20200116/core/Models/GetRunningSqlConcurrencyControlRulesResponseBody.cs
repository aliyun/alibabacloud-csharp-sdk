// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRunningSqlConcurrencyControlRulesResponseBody : TeaModel {
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
        public GetRunningSqlConcurrencyControlRulesResponseBodyData Data { get; set; }
        public class GetRunningSqlConcurrencyControlRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetRunningSqlConcurrencyControlRulesResponseBodyDataList List { get; set; }
            public class GetRunningSqlConcurrencyControlRulesResponseBodyDataList : TeaModel {
                [NameInMap("runningRules")]
                [Validation(Required=false)]
                public List<GetRunningSqlConcurrencyControlRulesResponseBodyDataListRunningRules> RunningRules { get; set; }
                public class GetRunningSqlConcurrencyControlRulesResponseBodyDataListRunningRules : TeaModel {
                    /// <summary>
                    /// <para>The duration within which the SQL throttling rule takes effect. Unit: seconds.</para>
                    /// <remarks>
                    /// <para>The throttling rule takes effect only within this duration.</para>
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
                    /// <para>The hash value of the SQL keywords. The hash value is calculated based on the SQL keywords that are contained in the SQL statements to which the throttling rule is applied.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b0b8aceeb43baea87b219c81767b****</para>
                    /// </summary>
                    [NameInMap("KeywordsHash")]
                    [Validation(Required=false)]
                    public string KeywordsHash { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent SQL statements. The value is a positive integer.</para>
                    /// <remarks>
                    /// <para>If the number of concurrent SQL statements that contain the specified keywords reaches this upper limit, the throttling rule is triggered.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaxConcurrency")]
                    [Validation(Required=false)]
                    public string MaxConcurrency { get; set; }

                    /// <summary>
                    /// <para>The keywords contained in the SQL statements to which the throttling rule was applied.</para>
                    /// <remarks>
                    /// <para>SQL keywords are separated by tildes (~). If the number of concurrent SQL statements that contain all the specified SQL keywords reaches the specified upper limit, the throttling rule is triggered.</para>
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
                    /// <para>The time when the throttling rule started to take effect. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1608888296000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The status of the throttling rule. The value of <b>Open</b> indicates that the throttling rule is in effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Open</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud account ID.</para>
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
            /// <para>2</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
