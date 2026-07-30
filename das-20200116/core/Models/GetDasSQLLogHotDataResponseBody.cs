// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDasSQLLogHotDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDasSQLLogHotDataResponseBodyData Data { get; set; }
        public class GetDasSQLLogHotDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public object Extra { get; set; }

            /// <summary>
            /// <para>A list of the returned data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetDasSQLLogHotDataResponseBodyDataList> List { get; set; }
            public class GetDasSQLLogHotDataResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testuser</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDB</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The UTC time when the execution was recorded, formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-23 T12:11:20Z</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public string Ext { get; set; }

                /// <summary>
                /// <para>The client IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX</para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <para>The latency, in microseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Latancy")]
                [Validation(Required=false)]
                public long? Latancy { get; set; }

                /// <summary>
                /// <para>The lock wait time, in microseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public long? LockTime { get; set; }

                /// <summary>
                /// <para>The number of logical reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("LogicRead")]
                [Validation(Required=false)]
                public long? LogicRead { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pi-bp120roy76f3qbd84</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The precise UTC time when the execution was recorded, formatted as <c>yyyy-MM-ddTHH:mm:ss.SSSZ</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-23 T12:11:20.999Z</para>
                /// </summary>
                [NameInMap("OriginTime")]
                [Validation(Required=false)]
                public string OriginTime { get; set; }

                /// <summary>
                /// <para>The number of physical asynchronous reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicAsyncRead")]
                [Validation(Required=false)]
                public long? PhysicAsyncRead { get; set; }

                /// <summary>
                /// <para>The number of physical synchronous reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicSyncRead")]
                [Validation(Required=false)]
                public long? PhysicSyncRead { get; set; }

                /// <summary>
                /// <para>The number of returned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public long? ReturnRows { get; set; }

                /// <summary>
                /// <para>The SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select 1</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// <para>The number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("ScanRows")]
                [Validation(Required=false)]
                public long? ScanRows { get; set; }

                /// <summary>
                /// <para>The SQL type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>select</b></para>
                /// </description></item>
                /// <item><description><para><b>update</b></para>
                /// </description></item>
                /// <item><description><para><b>delete</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>select</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>The execution status. A value of <b>0</b> indicates success. Any other value is an error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The thread ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>657</para>
                /// </summary>
                [NameInMap("ThreadID")]
                [Validation(Required=false)]
                public long? ThreadID { get; set; }

                /// <summary>
                /// <para>The transaction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TransactionId")]
                [Validation(Required=false)]
                public string TransactionId { get; set; }

                /// <summary>
                /// <para>The number of updated rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UpdateRows")]
                [Validation(Required=false)]
                public long? UpdateRows { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>If the request succeeds, <b>Successful</b> is returned. If the request fails, an error message is returned, which may include an error code.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID generated by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A74B755-98B7-59DB-8724-1321B394****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
