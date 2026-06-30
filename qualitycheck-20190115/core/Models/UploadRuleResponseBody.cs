// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UploadRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. <b>200</b> means success. Any other value indicates failure. Use this field to diagnose errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadRuleResponseBodyData Data { get; set; }
        public class UploadRuleResponseBodyData : TeaModel {
            [NameInMap("RidInfo")]
            [Validation(Required=false)]
            public List<string> RidInfo { get; set; }

        }

        /// <summary>
        /// <para>Error details if the call fails. <b>successful</b> if successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4987D326-83D9-4A42-B9A5-0B27F9B40539</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request succeeded. Use this field to verify success:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> means success.</para>
        /// </description></item>
        /// <item><description><para>false or <b>null</b> means failure.</para>
        /// </description></item>
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
