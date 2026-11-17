// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class MakePilotCallRequest : TeaModel {
        /// <summary>
        /// <para>The variables passed to the phone call link. The value is a JSON object string, and variable values are processed as strings. Specific variable names are agreed upon by the call link and business scenario. This parameter is not semicolon-separated Tags. The example uses an empty object when no custom variables are defined.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CallVariables")]
        [Validation(Required=false)]
        public string CallVariables { get; set; }

        /// <summary>
        /// <para>The ID of the client device that initiates the web voice or receives data channel events. The same client must use the same DeviceId when obtaining data channel credentials and initiating a call. The example is only a business device ID and not a real credential assigned by the platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the draft version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Uses the draft version.</description></item>
        /// <item><description>false: Uses the published version.
        /// This parameter does not publish the scenario. Ensure that the selected scenario version exists before you call this operation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DraftVersion")]
        [Validation(Required=false)]
        public bool? DraftVersion { get; set; }

        /// <summary>
        /// <para>The instance identity of the product. You must use an instance that the invoker has access to and that actually exists. The instance must be consistent with the instance to which the scenario, channel, and session belong. The maximum length is subject to the current POP parameter definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-example-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The called phone number for the current real-number outbound call test. The number must be the same as the one used to obtain the SMS verification code. Specify a number that is actually supported by the business and authorized. The current request object only requires this parameter to be non-empty. This document does not fabricate number formats or international number support scopes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800000000</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The dialog scenario ID of the instance. Specify an existing scenario. Subsequent dialog and end requests for the same text session must use the scenario specified when the session is started.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>script-example-001</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The attached data string passed to the call link. Use the key=value format. Separate multiple key-value pairs with semicolons. Do not use JSON. For example, the Callee key can be used by the web call service to read the called party information. The example number is a placeholder value. Specify the actual value based on the access conventions of your business. Do not overwrite internal tags that do not belong to the business custom scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Callee=057100000000</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The SMS verification code sent to the number specified by Number for the verification of the OutboundCallTest scenario. The request must use a valid verification code actually received by the number. The example only demonstrates a string parameter and cannot be used to pass the verification. It also does not declare undefined length rules for the code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}
