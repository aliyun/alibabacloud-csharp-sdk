// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AddCasesRequest : TeaModel {
        /// <summary>
        /// <para>The predictive outbound call activity ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c58b9719-3bc3-441d-a4d3-fc0309ef7066</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>The list of outbound call cases.</para>
        /// </summary>
        [NameInMap("CaseList")]
        [Validation(Required=false)]
        public List<AddCasesRequestCaseList> CaseList { get; set; }
        public class AddCasesRequestCaseList : TeaModel {
            /// <summary>
            /// <para>The caller number. If this field is specified, the corresponding contact will be called using this number instead of a randomly selected one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>185022xxxx</para>
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            /// <summary>
            /// <para>Customer-defined custom variables in JSON object format. The object can contain up to 10 properties, and both the name and value of each property are defined by the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;customer&quot;,&quot;客户标签&quot;:&quot;tag&quot;}</para>
            /// </summary>
            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            /// <summary>
            /// <para>The desensitized callee number. If this field is not empty, it indicates that the callee number must be desensitized. The desensitization rule is defined by the customer, and only the desensitized callee number needs to be provided here. Using a desensitized callee number means that in certain scenarios, the displayed callee number will be the desensitized version, and the real callee number cannot be viewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>166******66</para>
            /// </summary>
            [NameInMap("MaskedCallee")]
            [Validation(Required=false)]
            public string MaskedCallee { get; set; }

            /// <summary>
            /// <para>The contact\&quot;s phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188888****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The business ID, which is an identifier from the customer\&quot;s operational system used in integration scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

        }

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

    }

}
