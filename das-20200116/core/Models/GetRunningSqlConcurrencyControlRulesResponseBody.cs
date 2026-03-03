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
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetRunningSqlConcurrencyControlRulesResponseBodyDataList List { get; set; }
            public class GetRunningSqlConcurrencyControlRulesResponseBodyDataList : TeaModel {
                [NameInMap("runningRules")]
                [Validation(Required=false)]
                public List<GetRunningSqlConcurrencyControlRulesResponseBodyDataListRunningRules> RunningRules { get; set; }
                public class GetRunningSqlConcurrencyControlRulesResponseBodyDataListRunningRules : TeaModel {
                    [NameInMap("ConcurrencyControlTime")]
                    [Validation(Required=false)]
                    public long? ConcurrencyControlTime { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    [NameInMap("KeywordsHash")]
                    [Validation(Required=false)]
                    public string KeywordsHash { get; set; }

                    [NameInMap("MaxConcurrency")]
                    [Validation(Required=false)]
                    public string MaxConcurrency { get; set; }

                    [NameInMap("SqlKeywords")]
                    [Validation(Required=false)]
                    public string SqlKeywords { get; set; }

                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

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
