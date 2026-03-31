// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecUserOperationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation records.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecUserOperationsResponseBodyData> Data { get; set; }
        public class DescribeApisecUserOperationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The state before the operation.</para>
            /// <para>Valid values of the risk state:</para>
            /// <list type="bullet">
            /// <item><description><b>toBeConfirmed</b></description></item>
            /// <item><description><b>confirmed</b></description></item>
            /// <item><description><b>toBeFixed</b></description></item>
            /// <item><description><b>fixed</b></description></item>
            /// <item><description><b>ignored</b></description></item>
            /// </list>
            /// <para>Valid values of the event state:</para>
            /// <list type="bullet">
            /// <item><description><b>toBeConfirmed</b></description></item>
            /// <item><description><b>confirmed</b></description></item>
            /// <item><description><b>ignored</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ignored</para>
            /// </summary>
            [NameInMap("FromStatus")]
            [Validation(Required=false)]
            public string FromStatus { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Handled</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The object ID of the operation record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24d997acc48a67a01e09b9c5ad861287</para>
            /// </summary>
            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            [NameInMap("OperationSource")]
            [Validation(Required=false)]
            public string OperationSource { get; set; }

            /// <summary>
            /// <para>The time at which the operation was performed. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1685072214</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The state after the operation.</para>
            /// <para>Valid values of the risk state:</para>
            /// <list type="bullet">
            /// <item><description><b>toBeConfirmed</b></description></item>
            /// <item><description><b>confirmed</b></description></item>
            /// <item><description><b>toBeFixed</b></description></item>
            /// <item><description><b>fixed</b></description></item>
            /// <item><description><b>ignored</b></description></item>
            /// </list>
            /// <para>Valid values of the event state:</para>
            /// <list type="bullet">
            /// <item><description><b>toBeConfirmed</b></description></item>
            /// <item><description><b>confirmed</b></description></item>
            /// <item><description><b>ignored</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Confirmed</para>
            /// </summary>
            [NameInMap("ToStatus")]
            [Validation(Required=false)]
            public string ToStatus { get; set; }

            /// <summary>
            /// <para>The type of the operation record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>abnormal</b>: risk detection</description></item>
            /// <item><description><b>event</b>: security event</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>abnormal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610954****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9825654-327B-5156-A570-847054B4CF10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
