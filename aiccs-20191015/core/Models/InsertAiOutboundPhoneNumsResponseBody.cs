// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class InsertAiOutboundPhoneNumsResponseBody : TeaModel {
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
        /// <para>Import result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertAiOutboundPhoneNumsResponseBodyData Data { get; set; }
        public class InsertAiOutboundPhoneNumsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details of failed numbers.</para>
            /// </summary>
            [NameInMap("FailInfo")]
            [Validation(Required=false)]
            public List<InsertAiOutboundPhoneNumsResponseBodyDataFailInfo> FailInfo { get; set; }
            public class InsertAiOutboundPhoneNumsResponseBodyDataFailInfo : TeaModel {
                /// <summary>
                /// <para>Custom business information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("BizData")]
                [Validation(Required=false)]
                public string BizData { get; set; }

                /// <summary>
                /// <para>Description of the failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>号码格式异常</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The callee number for outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150****0000</para>
                /// </summary>
                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

            }

            /// <summary>
            /// <para>Number of successfully imported entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>Total number of imported entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.  </description></item>
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
