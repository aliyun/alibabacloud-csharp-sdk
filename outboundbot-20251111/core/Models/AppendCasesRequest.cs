// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class AppendCasesRequest : TeaModel {
        /// <summary>
        /// <para>The outbound call task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40ea7fc2-c9d4-47e3-af1e-216bf7f79a44</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>The list of contacts.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Cases")]
        [Validation(Required=false)]
        public List<AppendCasesRequestCases> Cases { get; set; }
        public class AppendCasesRequestCases : TeaModel {
            /// <summary>
            /// <para>The custom variables defined by the customer. The value is a JSON object that contains up to 10 properties. The name and value of each property are defined by the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;key1&quot;:&quot;value1&quot;]</para>
            /// </summary>
            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            /// <summary>
            /// <para>The phone number of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1331234****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The business system ID of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business3-watermark-2704-1776997551</para>
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
        /// <para>361c8a53-0e29-42f3-8aa7-c7752d010399</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
