// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateConditionalAccessPolicyDescriptionRequest : TeaModel {
        /// <summary>
        /// <para>Idp client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-examplexxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Conditional Access Policy ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap_11111</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyId")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyId { get; set; }

        /// <summary>
        /// <para>Description of the conditional access policy</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
