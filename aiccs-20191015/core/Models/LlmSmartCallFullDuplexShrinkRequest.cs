// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class LlmSmartCallFullDuplexShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>ApplicationCode</b><br>The application code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app123</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para><b>CalledNumber</b><br>The phone number that receives the intelligent outbound call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para><b>CallerNumber</b><br>The calling number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0987654321</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <para><b>OutId</b><br>The external ID. The value must be 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out123</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <para><b>SessionTimeout</b><br>The maximum call duration. The call is automatically ended when the specified duration is exceeded. Unit: seconds. Maximum value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para><b>StartWordParam</b><br>The opening greeting variable. Format: JSON. Specify the variable name and parameter, for example, <c>{&quot;custom&quot;:&quot;XXX&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;tailnumber\&quot;:\&quot;7898\&quot;,\&quot;platformOrder\&quot;:\&quot;\&quot;,\&quot;signatory\&quot;:\&quot;客户\&quot;}</para>
        /// </summary>
        [NameInMap("StartWordParam")]
        [Validation(Required=false)]
        public string StartWordParamShrink { get; set; }

        /// <summary>
        /// <para>The voice speed. Valid values: 0 to 100. If this parameter is not specified, the value configured in the application is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        /// <summary>
        /// <para>The voice code from the personalized voice interface. If this parameter is not specified, the value configured in the application is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V745A7CED</para>
        /// </summary>
        [NameInMap("TtsVoiceCode")]
        [Validation(Required=false)]
        public string TtsVoiceCode { get; set; }

        /// <summary>
        /// <para>The volume. Valid values: -200 to 200. If this parameter is not specified, the value configured in the application is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

    }

}
