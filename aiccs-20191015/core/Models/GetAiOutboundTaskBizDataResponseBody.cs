// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskBizDataResponseBody : TeaModel {
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
        /// <para>The business information associated with this call.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskBizDataResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskBizDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Custom business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;customer&quot;:123}</para>
            /// </summary>
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            /// <summary>
            /// <para>The Activity ID associated with this outbound call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CaseId")]
            [Validation(Required=false)]
            public long? CaseId { get; set; }

            /// <summary>
            /// <para>The outbound phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>158****0000</para>
            /// </summary>
            [NameInMap("PhoneNum")]
            [Validation(Required=false)]
            public string PhoneNum { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
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
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
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
