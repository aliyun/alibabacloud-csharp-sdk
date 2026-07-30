// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadLockDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data in JSON format:</para>
        /// <list type="bullet">
        /// <item><description><para>accountId: the user ID.</para>
        /// </description></item>
        /// <item><description><para>textId: the deadlock text ID.</para>
        /// </description></item>
        /// <item><description><para>gmtModified: the time when the diagnosis was generated.</para>
        /// </description></item>
        /// <item><description><para>originText: the original deadlock text of LATEST DETECTED DEADLOCK or the original deadlock text in the error log.</para>
        /// </description></item>
        /// <item><description><para>deadlock: the deadlock details:</para>
        /// <list type="bullet">
        /// <item><description><para>occurTime: the time when the deadlock occurred.</para>
        /// </description></item>
        /// <item><description><para>originTextId: the deadlock text ID.</para>
        /// </description></item>
        /// <item><description><para>rollbackTrxId: the ID of the rolled back transaction.</para>
        /// </description></item>
        /// <item><description><para>transactions:</para>
        /// <list type="bullet">
        /// <item><description><para>deadlockIdInDB: the deadlock ID in the database.</para>
        /// </description></item>
        /// <item><description><para>ip: the access IP address.</para>
        /// </description></item>
        /// <item><description><para>queryId: the query ID.</para>
        /// </description></item>
        /// <item><description><para>queryType: the query type.</para>
        /// </description></item>
        /// <item><description><para>relatedTables: the related tables.</para>
        /// </description></item>
        /// <item><description><para>tableNamesString: the related tables.</para>
        /// </description></item>
        /// <item><description><para>sqlText: the SQL text.</para>
        /// </description></item>
        /// <item><description><para>threadId: the thread ID.</para>
        /// </description></item>
        /// <item><description><para>transactionId: the transaction ID.</para>
        /// </description></item>
        /// <item><description><para>trxIdInLock: the transaction ID in the deadlock.</para>
        /// </description></item>
        /// <item><description><para>userName: the database username.</para>
        /// </description></item>
        /// <item><description><para>waitLockIndexName: the name of the index for which the lock is waiting.</para>
        /// </description></item>
        /// <item><description><para>waitLockMode: the type of the lock that is waiting.</para>
        /// </description></item>
        /// <item><description><para>lockWait: the waiting lock.</para>
        /// </description></item>
        /// <item><description><para>holdLockIndexName: the name of the index for which the lock is held.</para>
        /// </description></item>
        /// <item><description><para>holdLockMode: the type of the lock that is held.</para>
        /// </description></item>
        /// <item><description><para>lockHold: the held lock.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>trxNum: the number of transactions.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>gmtCreate: the time when the diagnosis was created.</para>
        /// </description></item>
        /// <item><description><para>nodeId: the node ID.</para>
        /// </description></item>
        /// <item><description><para>uuid: the instance ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;accountId&quot;: &quot;108************&quot;,
        ///     &quot;textId&quot;: &quot;35303d12d52d29ba73bb************&quot;,
        ///     &quot;gmtModified&quot;: 1732712680000,
        ///     &quot;originText&quot;: &quot;LATEST DETECTED DEADLOCK****&quot;,
        ///     &quot;deadlock&quot;: &quot;{\&quot;id\&quot;:0,\&quot;occurTime\&quot;:1732687047000,\&quot;originTextId\&quot;:\&quot;35303d12d52d29ba73bb************\&quot;,\&quot;rollbackTrxId\&quot;:\&quot;2\&quot;,\&quot;transactions\&quot;:[{\&quot;deadlockIdInDB\&quot;:0,\&quot;ip\&quot;:\&quot;100.<em><b>.</b></em>.<em><b>\&quot;,\&quot;lockWait\&quot;:\&quot;index PRIMARY of table <c>das</c>.<c>students</c> trx id 15989454 lock_mode X locks rec but not gap waiting\&quot;,\&quot;queryId\&quot;:\&quot;386737457\&quot;,\&quot;queryType\&quot;:\&quot;updating\&quot;,\&quot;relatedTables\&quot;:[\&quot;<c>das</c>.<c>students</c>\&quot;],\&quot;sqlText\&quot;:\&quot;update students set name=UUID() where id = 2 \&quot;,\&quot;tableNamesString\&quot;:\&quot;<c>das</c>.<c>students</c>\&quot;,\&quot;threadId\&quot;:\&quot;9194526\&quot;,\&quot;transactionId\&quot;:\&quot;15989454\&quot;,\&quot;trxIdInLock\&quot;:1,\&quot;userName\&quot;:\&quot;das\&quot;,\&quot;waitLockIndexName\&quot;:\&quot;PRIMARY \&quot;,\&quot;waitLockMode\&quot;:\&quot;X locks rec but not gap waiting\&quot;},{\&quot;deadlockIdInDB\&quot;:0,\&quot;holdLockIndexName\&quot;:\&quot;PRIMARY \&quot;,\&quot;holdLockMode\&quot;:\&quot;X locks rec but not gap\&quot;,\&quot;ip\&quot;:\&quot;100.</b></em>.<em><b>.</b></em>\&quot;,\&quot;lockHold\&quot;:\&quot;index PRIMARY of table <c>das</c>.<c>students</c> trx id 15989451 lock_mode X locks rec but not gap\&quot;,\&quot;lockWait\&quot;:\&quot;index PRIMARY of table <c>das</c>.<c>students</c> trx id 15989451 lock_mode X locks rec but not gap waiting\&quot;,\&quot;queryId\&quot;:\&quot;386737566\&quot;,\&quot;queryType\&quot;:\&quot;updating\&quot;,\&quot;relatedTables\&quot;:[\&quot;<c>das</c>.<c>students</c>\&quot;],\&quot;sqlText\&quot;:\&quot;update students set name=UUID() where id = 3 \&quot;,\&quot;tableNamesString\&quot;:\&quot;<c>das</c>.<c>students</c>\&quot;,\&quot;threadId\&quot;:\&quot;9194501\&quot;,\&quot;transactionId\&quot;:\&quot;15989451\&quot;,\&quot;trxIdInLock\&quot;:2,\&quot;userName\&quot;:\&quot;das\&quot;,\&quot;waitLockIndexName\&quot;:\&quot;PRIMARY \&quot;,\&quot;waitLockMode\&quot;:\&quot;X locks rec but not gap waiting\&quot;}],\&quot;trxNum\&quot;:2}&quot;,
        ///     &quot;gmtCreate&quot;: 1732712680000,
        ///     &quot;nodeId&quot;: &quot;pi-8****************&quot;,
        ///     &quot;uuid&quot;: &quot;pc-8v***************&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>When the request is successful, <b>Successful</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>When the request fails, error information (such as error codes) is returned.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9CB97BC4-6479-55D0-B9D0-EA925AFE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
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

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public string Synchro { get; set; }

    }

}
