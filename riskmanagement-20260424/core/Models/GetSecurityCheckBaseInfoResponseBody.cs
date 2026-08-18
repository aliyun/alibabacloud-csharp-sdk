// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetSecurityCheckBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para> 200: Success. Other codes (500, 400, etc.): Error codes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecurityCheckBaseInfoResponseBodyData Data { get; set; }
        public class GetSecurityCheckBaseInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the security check is enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the security check is completed.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Completed.</description></item>
            /// <item><description><b>false</b>: Not completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskCompleted")]
            [Validation(Required=false)]
            public bool? TaskCompleted { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B57D35D-9DAC-5393-AE39-07697E37C2E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
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
