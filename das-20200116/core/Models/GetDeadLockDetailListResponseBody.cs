// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadLockDetailListResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeadLockDetailListResponseBodyData Data { get; set; }
        public class GetDeadLockDetailListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the data returned.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetDeadLockDetailListResponseBodyDataList> List { get; set; }
            public class GetDeadLockDetailListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The time when the data was collected. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702301170701</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public long? BatchId { get; set; }

                /// <summary>
                /// <para>The blocking details of the instance. The details are information about the session that caused the lock.</para>
                /// </summary>
                [NameInMap("BlockProcessList")]
                [Validation(Required=false)]
                public List<GetDeadLockDetailListResponseBodyDataListBlockProcessList> BlockProcessList { get; set; }
                public class GetDeadLockDetailListResponseBodyDataListBlockProcessList : TeaModel {
                    /// <summary>
                    /// <para>The name of the client that initiates the transaction in the session.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Microsoft SQL Server Management Studio - Query</para>
                    /// </summary>
                    [NameInMap("ClientApp")]
                    [Validation(Required=false)]
                    public string ClientApp { get; set; }

                    /// <summary>
                    /// <para>The name of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>school</para>
                    /// </summary>
                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    /// <summary>
                    /// <para>The hostname.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sd74020124</para>
                    /// </summary>
                    [NameInMap("HostName")]
                    [Validation(Required=false)]
                    public string HostName { get; set; }

                    /// <summary>
                    /// <para>The time when the transaction was started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1702301152000</para>
                    /// </summary>
                    [NameInMap("LastTranStarted")]
                    [Validation(Required=false)]
                    public long? LastTranStarted { get; set; }

                    /// <summary>
                    /// <para>The mode of the lock. For more information, see <a href="https://help.aliyun.com/document_detail/2362804.html">Lock modes</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>U</para>
                    /// </summary>
                    [NameInMap("LockMode")]
                    [Validation(Required=false)]
                    public string LockMode { get; set; }

                    /// <summary>
                    /// <para>The size of the logs generated in the session. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>352</para>
                    /// </summary>
                    [NameInMap("LogUsed")]
                    [Validation(Required=false)]
                    public long? LogUsed { get; set; }

                    /// <summary>
                    /// <para>The logon name of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sd74020124\\Administrator</para>
                    /// </summary>
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    /// <summary>
                    /// <para>The locked object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>school.dbo.test2</para>
                    /// </summary>
                    [NameInMap("ObjectOwned")]
                    [Validation(Required=false)]
                    public string ObjectOwned { get; set; }

                    /// <summary>
                    /// <para>The object that the transaction requested to lock.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>school.dbo.test1</para>
                    /// </summary>
                    [NameInMap("ObjectRequested")]
                    [Validation(Required=false)]
                    public string ObjectRequested { get; set; }

                    /// <summary>
                    /// <para>The lock mode held by the session. For more information, see <a href="https://help.aliyun.com/document_detail/2362804.html">Lock modes</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X</para>
                    /// </summary>
                    [NameInMap("OwnMode")]
                    [Validation(Required=false)]
                    public string OwnMode { get; set; }

                    /// <summary>
                    /// <para>The ID of the session in which the transaction is started.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>61</para>
                    /// </summary>
                    [NameInMap("Spid")]
                    [Validation(Required=false)]
                    public long? Spid { get; set; }

                    /// <summary>
                    /// <para>The SQL statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>update test1 set col1 =9</para>
                    /// </summary>
                    [NameInMap("SqlText")]
                    [Validation(Required=false)]
                    public string SqlText { get; set; }

                    /// <summary>
                    /// <para>The status of the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>suspended</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the session is the victim of the deadlock. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: no.</description></item>
                    /// <item><description><b>1</b>: yes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Victim")]
                    [Validation(Required=false)]
                    public long? Victim { get; set; }

                    /// <summary>
                    /// <para>The lock mode requested by the session. For more information, see <a href="https://help.aliyun.com/document_detail/2362804.html">Lock modes</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>U</para>
                    /// </summary>
                    [NameInMap("WaitMode")]
                    [Validation(Required=false)]
                    public string WaitMode { get; set; }

                    /// <summary>
                    /// <para>The resources requested by the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RID: 5:1:312:0</para>
                    /// </summary>
                    [NameInMap("WaitResource")]
                    [Validation(Required=false)]
                    public string WaitResource { get; set; }

                    /// <summary>
                    /// <para>The details of the resources requested by the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RID:school:school.mdf:312:0</para>
                    /// </summary>
                    [NameInMap("WaitResourceDescription")]
                    [Validation(Required=false)]
                    public string WaitResourceDescription { get; set; }

                }

                /// <summary>
                /// <para>The name of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Microsoft SQL Server Management Studio - Query</para>
                /// </summary>
                [NameInMap("ClientApp")]
                [Validation(Required=false)]
                public string ClientApp { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>school</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sd74020124</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The time when the transaction was started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702301141000</para>
                /// </summary>
                [NameInMap("LastTranStarted")]
                [Validation(Required=false)]
                public long? LastTranStarted { get; set; }

                /// <summary>
                /// <para>The mode of the lock. For more information, see <a href="https://help.aliyun.com/document_detail/2362804.html">Lock modes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The size of the logs generated in the session. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>352</para>
                /// </summary>
                [NameInMap("LogUsed")]
                [Validation(Required=false)]
                public long? LogUsed { get; set; }

                /// <summary>
                /// <para>The logon name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sd74020124\\Administrator</para>
                /// </summary>
                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                /// <summary>
                /// <para>The locked object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>school.dbo.test1</para>
                /// </summary>
                [NameInMap("ObjectOwned")]
                [Validation(Required=false)]
                public string ObjectOwned { get; set; }

                /// <summary>
                /// <para>The object that the transaction requested to lock.</para>
                /// 
                /// <b>Example:</b>
                /// <para>school.dbo.test2</para>
                /// </summary>
                [NameInMap("ObjectRequested")]
                [Validation(Required=false)]
                public string ObjectRequested { get; set; }

                /// <summary>
                /// <para>The lock mode held by the session. For more information, see <a href="https://help.aliyun.com/document_detail/2362804.html">Lock modes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>X</para>
                /// </summary>
                [NameInMap("OwnMode")]
                [Validation(Required=false)]
                public string OwnMode { get; set; }

                /// <summary>
                /// <para>The ID of the session in which the transaction is started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("Spid")]
                [Validation(Required=false)]
                public long? Spid { get; set; }

                /// <summary>
                /// <para>The SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>update test2 set col1 =88</para>
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// <para>The status of the transaction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>suspended</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the session is the victim of the deadlock. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: no.</description></item>
                /// <item><description><b>1</b>: yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Victim")]
                [Validation(Required=false)]
                public long? Victim { get; set; }

                /// <summary>
                /// <para>The lock mode requested by the session. For more information, see <a href="https://help.aliyun.com/document_detail/2362804.html">Lock modes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U</para>
                /// </summary>
                [NameInMap("WaitMode")]
                [Validation(Required=false)]
                public string WaitMode { get; set; }

                /// <summary>
                /// <para>The resources requested by the transaction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RID: 5:1:376:0</para>
                /// </summary>
                [NameInMap("WaitResource")]
                [Validation(Required=false)]
                public string WaitResource { get; set; }

                /// <summary>
                /// <para>The details of the resources requested by the transaction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RID:school:school.mdf:376:0</para>
                /// </summary>
                [NameInMap("WaitResourceDescription")]
                [Validation(Required=false)]
                public string WaitResourceDescription { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

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
        /// <para> If the request is successful, <b>Successful</b> is returned. Otherwise, an error message such as an error code is returned.</para>
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
        /// <para>840F51F7-9C01-538D-94F6-AE712905****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
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
