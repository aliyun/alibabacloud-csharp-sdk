// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FraudResultCallBackRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier for real-person authentication, corresponding to Ant\&quot;s verifyId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shs2b27333914876c01de4cb22f5841f</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Extended parameters, in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtParams")]
        [Validation(Required=false)]
        public string ExtParams { get; set; }

        /// <summary>
        /// <para>Whether the anti-fraud check passed</para>
        /// <list type="bullet">
        /// <item><description>PASS (Passed)</description></item>
        /// <item><description>REJECT (Rejected)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PASS</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <para>Environment routing parameter</para>
        /// <list type="bullet">
        /// <item><description>staging (Staging environment)</description></item>
        /// <item><description>production (Production environment)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("VerifyDeployEnv")]
        [Validation(Required=false)]
        public string VerifyDeployEnv { get; set; }

    }

}
