// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecUserOperationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The user operation records for API security.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecUserOperationsResponseBodyData> Data { get; set; }
        public class DescribeApisecUserOperationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of the threat detection or security event before the operation was performed.</para>
            /// <para>Valid values for threat detection:</para>
            /// <list type="bullet">
            /// <item><description><para><b>toBeConfirmed</b>: to be confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>confirmed</b>: confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>toBeFixed</b>: to be fixed.</para>
            /// </description></item>
            /// <item><description><para><b>fixed</b>: fixed.</para>
            /// </description></item>
            /// <item><description><para><b>ignored</b>: ignored.</para>
            /// </description></item>
            /// </list>
            /// <para>Valid values for a security event:</para>
            /// <list type="bullet">
            /// <item><description><para><b>toBeConfirmed</b>: to be confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>confirmed</b>: confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>ignored</b>: ignored.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ignored</para>
            /// </summary>
            [NameInMap("FromStatus")]
            [Validation(Required=false)]
            public string FromStatus { get; set; }

            /// <summary>
            /// <para>The remarks that the user added to the operation record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Procesed</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The ID of the threat detection or security event associated with the operation record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24d997acc48a67a01e09b9c5ad861287</para>
            /// </summary>
            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The source of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>system</b>: the operation was automatically performed by the system.</para>
            /// </description></item>
            /// <item><description><para><b>custom</b>: the operation was manually performed by a user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("OperationSource")]
            [Validation(Required=false)]
            public string OperationSource { get; set; }

            /// <summary>
            /// <para>The time when the operation was performed. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1685072214</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The status of the threat detection or security event after the operation was performed.</para>
            /// <para>Valid values for threat detection:</para>
            /// <list type="bullet">
            /// <item><description><para><b>toBeConfirmed</b>: to be confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>confirmed</b>: confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>toBeFixed</b>: to be fixed.</para>
            /// </description></item>
            /// <item><description><para><b>fixed</b>: fixed.</para>
            /// </description></item>
            /// <item><description><para><b>ignored</b>: ignored.</para>
            /// </description></item>
            /// </list>
            /// <para>Valid values for a security event:</para>
            /// <list type="bullet">
            /// <item><description><para><b>toBeConfirmed</b>: to be confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>confirmed</b>: confirmed.</para>
            /// </description></item>
            /// <item><description><para><b>ignored</b>: ignored.</para>
            /// </description></item>
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
            /// <item><description><para><b>abnormal</b>: threat detection.</para>
            /// </description></item>
            /// <item><description><para><b>event</b>: security event.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>abnormal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the user who performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610954****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9825654-327B-5156-A570-847054B4CF10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
