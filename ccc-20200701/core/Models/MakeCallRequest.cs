// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class MakeCallRequest : TeaModel {
        /// <summary>
        /// <para>Callee number. For internal calls, specify the target agent\&quot;s extension number in this field. For outbound calls, specify the customer\&quot;s phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1318888****</para>
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        /// <summary>
        /// <para>Caller number. This parameter is invalid for internal calls. For outbound calls, specify an outbound number available to the current agent. Ensure that the number supports outbound calling and that the agent has permission to use it. Permission can be granted in two ways: either by attaching the number to the skill group the agent signed into, or by setting the number as the agent\&quot;s personal outbound number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>010989****</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>Device ID. This field is meaningless and can be filled with any value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Flash SMS configuration</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;applicationId\&quot;:\&quot;6bd18325-ea7f-4881-8902-4d06283d3b3b\&quot;,\&quot;templateId\&quot;:\&quot;1722217249064\&quot;}</para>
        /// </summary>
        [NameInMap("FlashSmsVariables")]
        [Validation(Required=false)]
        public string FlashSmsVariables { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The desensitized callee number. If this field is not empty, it indicates that the callee number must be desensitized. The desensitization rule is defined by the customer. You only need to enter the desensitized callee number here. Using a desensitized callee number means that in certain scenarios, you will see the desensitized callee number and cannot view the real callee number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****8888</para>
        /// </summary>
        [NameInMap("MaskedCallee")]
        [Validation(Required=false)]
        public string MaskedCallee { get; set; }

        /// <summary>
        /// <para>Media type. The default value is AUDIO. Other valid values include VIDEO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUDIO</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>Ingest endpoint data. The customer does not need to concern themselves with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tags</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Timeout. If the call is not answered within the time specified by this parameter, the system automatically hangs up. Valid values range from 30 to 300 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>Agent ID initiating the outbound call. This field is optional. If not specified, the system uses the agent mapped to the current RAM user by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
