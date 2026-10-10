// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AppendCasesRequest : TeaModel {
        /// <summary>
        /// <para>The predictive outbound campaign ID.</para>
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
        /// <para>The list of outbound call cases in the request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<AppendCasesRequestBody> Body { get; set; }
        public class AppendCasesRequestBody : TeaModel {
            /// <summary>
            /// <para>The agent ID of the specified agent to which the call is transferred. If this field is not empty, the system transfers the call to the specified agent. If this field is empty, the system assigns the call to an idle agent in the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The caller number. If this field is not empty, the outbound call system preferentially uses the provided number as the caller to initiate the call. If this field is empty, the system automatically selects a caller number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01012345678</para>
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            /// <summary>
            /// <para>The custom variables defined by the customer. The value is a JSON object that contains up to 10 properties. The name and value of each property are defined by the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;name&quot;: &quot;customer&quot;,
            ///       &quot;Customer tag&quot;: &quot;tag&quot;
            /// }</para>
            /// </summary>
            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            /// <summary>
            /// <para>The masked callee number. If this field is not empty, the callee number is masked based on custom rules defined by the customer. You only need to enter the masked callee number. If a masked callee number is used, the masked number is displayed in certain scenarios, and the actual callee number cannot be viewed.</para>
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
            /// <para>The business ID, which is the identifier in the customer\&quot;s business system and is used for integration scenarios.</para>
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
