// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class CreateVccGrantRuleRequest : TeaModel {
        /// <summary>
        /// <para>Lingjun HUB ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>Authorized Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620939556166277</para>
        /// </summary>
        [NameInMap("GrantTenantId")]
        [Validation(Required=false)]
        public string GrantTenantId { get; set; }

        /// <summary>
        /// <para>Network Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-8rgvqazb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
