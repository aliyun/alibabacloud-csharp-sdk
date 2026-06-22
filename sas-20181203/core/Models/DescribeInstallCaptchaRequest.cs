// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCaptchaRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the installation verification code. If this parameter is left empty, only valid installation verification codes are queried.</para>
        /// <remarks>
        /// <para>The installation verification code can be used only within its validity period. An expired installation verification code cannot be used to install the Security Center Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-11 16:26:22</para>
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
