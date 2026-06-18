// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskExecDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of task executions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskExecDetailResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskExecDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Indicates whether a next page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public bool? HasNextPage { get; set; }

            /// <summary>
            /// <para>List of outbound call executions.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAiOutboundTaskExecDetailResponseBodyDataList> List { get; set; }
            public class GetAiOutboundTaskExecDetailResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Job batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchVersion")]
                [Validation(Required=false)]
                public int? BatchVersion { get; set; }

                /// <summary>
                /// <para>Custom business information</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BizData")]
                [Validation(Required=false)]
                public string BizData { get; set; }

                /// <summary>
                /// <para>The number of outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public int? CallCount { get; set; }

                /// <summary>
                /// <para>The activity ID associated with this outbound call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public long? CaseId { get; set; }

                /// <summary>
                /// <para>Number import time. UNIX timestamp format, unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1632289999000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Result of the last outbound call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未接通</para>
                /// </summary>
                [NameInMap("LastCallResult")]
                [Validation(Required=false)]
                public string LastCallResult { get; set; }

                /// <summary>
                /// <para>Outbound phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150****0000</para>
                /// </summary>
                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                /// <summary>
                /// <para>Execution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Pending call.</description></item>
                /// <item><description><b>2</b>: Calling.</description></item>
                /// <item><description><b>3</b>: Completed.</description></item>
                /// <item><description><b>4</b>: Stopped.</description></item>
                /// <item><description><b>5</b>: Pending retry.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Execution status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>待呼叫</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public int? StatusDesc { get; set; }

            }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>199</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        /// <summary>
        /// <para>Status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API was invoked successfully.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
