// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaResponseBody : TeaModel {
        /// <summary>
        /// <para>The installation verification code for you to manually install the Security Center agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>M1HH**</para>
        /// </summary>
        [NameInMap("CaptchaCode")]
        [Validation(Required=false)]
        public string CaptchaCode { get; set; }

        /// <summary>
        /// <para>The validity period of the installation verification code.</para>
        /// <remarks>
        /// <para> The installation verification code is valid only within the validity period. An expired installation verification code cannot be used to install the agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-10 16:06:38</para>
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E5BFDCF-B9DD-430D-9DA4-151BCB581C9D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
