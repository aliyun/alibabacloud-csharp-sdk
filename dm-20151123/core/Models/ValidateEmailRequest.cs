// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ValidateEmailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to check the graylist. Default value: false. The result is asynchronously notified through EventBridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckGraylist")]
        [Validation(Required=false)]
        public bool? CheckGraylist { get; set; }

        /// <summary>
        /// <para>The email address to validate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxx@yyy.com">xxx@yyy.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The probe type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FULL: Enables all detection capabilities, including SMTP probing. Because SMTP probing involves remote connections, the overall latency is high. This value is suitable for scenarios that are not sensitive to response time. Each detection consumes 1 address validation quota.</description></item>
        /// <item><description>BASIC_ONLY: Enables all detection capabilities except SMTP probing, with low latency. This value is suitable for scenarios that are sensitive to response time, such as real-time validation during registration to check whether an email address is a disposable mailbox or an MX-forwarded abnormal address, to prevent batch registration by the cyber underground economy chain. Each detection consumes 1/3 of an address validation quota.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FULL</para>
        /// </summary>
        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

        /// <summary>
        /// <para>The timeout period. Default value: 60 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
