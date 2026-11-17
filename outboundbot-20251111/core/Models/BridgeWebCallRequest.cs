// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class BridgeWebCallRequest : TeaModel {
        /// <summary>
        /// <para>The caller information used to display and associate with the web call. This is not equivalent to the actual outbound caller phone number. If not provided or left empty, the current web call implementation uses the caller identifier as the caller display information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web-user-001</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>Identifies the client device that initiates the web voice call or receives data channel events. The same client must use the same DeviceId when obtaining data channel credentials and initiating a call. The example is only a business device identifier, not a real credential assigned by the platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Specifies the scenario version. A value of true indicates that the draft version is used. A value of false indicates that the published version is used. This is not a scenario publishing operation. Ensure that the selected scenario version exists before calling the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DraftVersion")]
        [Validation(Required=false)]
        public bool? DraftVersion { get; set; }

        /// <summary>
        /// <para>The instance identity of the associated product. You must use an existing instance that the invoker has permission to access. The instance must be consistent with the instance to which the scenario, channel, and session belong. The maximum length is subject to the current POP parameter definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-example-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The audio sample rate for the web voice, in Hz. The backend default is 8000. The sample rate must match the client audio and gateway capabilities. The current API code does not define a complete list of allowed values, and other sample rates are not documented as guaranteed supported enumerations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// <para>The dialogue scenario ID under the instance. Specify an existing scenario. Subsequent dialogue and end requests for the same text session must use the scenario specified when the session is started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>script-example-001</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The attached data string passed to the call link in key=value format. Separate multiple key-value pairs with semicolons instead of using JSON. For example, the web call service can read the Callee key to obtain the called party information. The example number is a placeholder value. Specify actual values based on your integration agreements. Do not overwrite internal tags that do not belong to the business custom scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Callee=057100000000</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The timeout for waiting for the call to be answered, in seconds. If the call is not answered within this period, it is actively hung up. The default value on the backend is 60 seconds. This does not represent the maximum duration of an answered call. The current request object does not declare additional upper and lower limits, and unverified value ranges are not added to the documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
