// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class InitSasModuleRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call fails. For more information, refer to error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The approval result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public InitSasModuleRuleResponseBodyData Data { get; set; }
        public class InitSasModuleRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Security Center request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14492571-0707-5130-85B4-4DDABB6BDF76</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>The error message. The value is the same as the Code parameter.</para>
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
        /// <para>2E130B0F-9E69-52FA-84FC-187FE1BA9489</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. true: The call is successful. false: The call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
