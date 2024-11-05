// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceTwoFactorResponseBody : TeaModel {
        /// <summary>
        /// <para>The settings of two-factor authentication.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetInstanceTwoFactorResponseBodyConfig Config { get; set; }
        public class GetInstanceTwoFactorResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether two-factor authentication is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTwoFactor")]
            [Validation(Required=false)]
            public bool? EnableTwoFactor { get; set; }

            /// <summary>
            /// <para>The duration within which two-factor authentication is not required after a local user passes two-factor authentication. Valid values: <c>0 to 168</c>. Unit: hours.</para>
            /// <remarks>
            /// <para>If 0 is returned, a local user must pass two-factor authentication every time the local user logs on to the bastion host.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SkipTwoFactorTime")]
            [Validation(Required=false)]
            public long? SkipTwoFactorTime { get; set; }

            /// <summary>
            /// <para>The two-factor authentication methods.</para>
            /// </summary>
            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
