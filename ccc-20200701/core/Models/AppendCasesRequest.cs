// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AppendCasesRequest : TeaModel {
        /// <summary>
        /// <para>The predictive campaign ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78cf6864-9a22-4ea8-a59d-5adc2d747b0e</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of cases to be added.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<AppendCasesRequestBody> Body { get; set; }
        public class AppendCasesRequestBody : TeaModel {
            /// <summary>
            /// <para>The agent ID. If you specify this parameter, the system routes the call to the specified agent. If you leave this parameter empty, the system routes the call to an idle agent in the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The caller number. If you specify this parameter, the system preferentially uses the specified number to initiate a call. If you leave this parameter empty, the system automatically selects a number to initiate a call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01012345678</para>
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            /// <summary>
            /// <para>Custom variables in the format of a JSON object. The object can contain up to 10 properties, and the name and value of each property are custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;name&quot;: &quot;customer&quot;,
            ///       &quot;客户标签&quot;: &quot;tag&quot;
            /// }</para>
            /// </summary>
            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            /// <summary>
            /// <para>The masked callee number. If this parameter is not empty, the callee number will be masked. You can define the masking rule and specify the masked callee number. In some cases, you can only view the masked callee number instead of the real one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>071*****801</para>
            /// </summary>
            [NameInMap("MaskedCallee")]
            [Validation(Required=false)]
            public string MaskedCallee { get; set; }

            /// <summary>
            /// <para>The phone number of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188888****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The business ID, which is a custom ID from your business system, used for integration purposes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

        }

    }

}
