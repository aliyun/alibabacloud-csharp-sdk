// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class HistoryThreeElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about why access is denied.</para>
        /// <remarks>
        /// <para>This parameter is returned only when RAM authentication fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of <c>OK</c> indicates the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other values, see the Error Codes section.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public HistoryThreeElementsVerificationResponseBodyData Data { get; set; }
        public class HistoryThreeElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The consistency of the verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: No record found.</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: The phone number, ID number, and name match the carrier\&quot;s records.</para>
            /// </description></item>
            /// <item><description><para><c>2</c>: The phone number and ID number match the carrier\&quot;s records, but the name does not.</para>
            /// </description></item>
            /// <item><description><para><c>3</c>: The phone number and name match the carrier\&quot;s records, but the ID number does not.</para>
            /// </description></item>
            /// <item><description><para><c>4</c>: The phone number matches the carrier\&quot;s records, but the name and ID number do not.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("IsConsistent")]
            [Validation(Required=false)]
            public long? IsConsistent { get; set; }

            /// <summary>
            /// <para>The carrier to which the request was routed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("RequestCarrier")]
            [Validation(Required=false)]
            public string RequestCarrier { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
