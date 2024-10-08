// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FraudResultCallBackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>shs2b27333914876c01de4cb22f5841f</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        [NameInMap("ExtParams")]
        [Validation(Required=false)]
        public string ExtParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PASS</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("VerifyDeployEnv")]
        [Validation(Required=false)]
        public string VerifyDeployEnv { get; set; }

    }

}
