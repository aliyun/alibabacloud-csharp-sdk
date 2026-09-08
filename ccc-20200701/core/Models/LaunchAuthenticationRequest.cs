// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class LaunchAuthenticationRequest : TeaModel {
        /// <summary>
        /// <para>The contact flow ID for the IVR identity verification flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af145gfc-1108-4d55-8fca-f719bd512ebb</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// <para>Variables passed to the contact flow. This parameter is optional. The configured variables can be retrieved and used within the IVR flow. The format is a JSON string representing a collection of key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;customerID&quot;: &quot;208880281831****&quot;,
        ///       &quot;operateType&quot;: &quot;cipherCode&quot;,
        ///       &quot;taskId&quot;: &quot;1234567890&quot;,
        ///       &quot;crmOther&quot;: &quot;123&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ContactFlowVariables")]
        [Validation(Required=false)]
        public string ContactFlowVariables { get; set; }

        /// <summary>
        /// <para>Device ID. This parameter is meaningless and can be filled in with any value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACC-YUNBS-1.0.10-****</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

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
        /// <para>The call ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-6538214103685****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The agent ID that initiates identity verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
