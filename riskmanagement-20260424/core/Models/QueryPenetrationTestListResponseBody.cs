// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryPenetrationTestListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: Success.</description></item>
        /// <item><description><b>Other values (such as 400 and 500)</b>: Failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPenetrationTestListResponseBodyData Data { get; set; }
        public class QueryPenetrationTestListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryPenetrationTestListResponseBodyDataList> List { get; set; }
            public class QueryPenetrationTestListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The application time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("ApplyTime")]
                [Validation(Required=false)]
                public long? ApplyTime { get; set; }

                /// <summary>
                /// <para>The type of the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EIP</b>: The public IP address of a VPC.</description></item>
                /// <item><description><b>SLB</b>: Server Load Balancer.</description></item>
                /// <item><description><b>ECS</b>: The public IP address of an ECS instance in the classic network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EIP</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <para>The unique identifier of the alert event record.</para>
                /// <remarks>
                /// <para>The data type of this field is Long. Precision loss may occur during the serialization or deserialization process. Make sure that the value does not exceed 9007199254740991.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>710864062</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The IP address of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.158.58</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The status of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>early_end</b>: The user applied for early termination.</description></item>
                /// <item><description><b>expired</b>: The authorization expired.</description></item>
                /// <item><description><b>auditing</b>: The application is being reviewed.</description></item>
                /// <item><description><b>approved</b>: The application is approved.</description></item>
                /// <item><description><b>rejected</b>: The application is rejected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>early_end</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The end time of the test.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("TestEndDate")]
                [Validation(Required=false)]
                public long? TestEndDate { get; set; }

                /// <summary>
                /// <para>The start date of the test.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("TestStartDate")]
                [Validation(Required=false)]
                public long? TestStartDate { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public QueryPenetrationTestListResponseBodyDataPageInfo PageInfo { get; set; }
            public class QueryPenetrationTestListResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The page number from which the query results are displayed.</para>
                /// <remarks>
                /// <para>Default value: 1, which indicates that the query results are displayed starting from the first page.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of entries returned per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99D93ED4-D462-5FC5-8518-9BC1C49C7B6C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.                               </description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
