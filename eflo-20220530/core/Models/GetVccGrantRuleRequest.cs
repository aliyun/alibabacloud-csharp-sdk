// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetVccGrantRuleRequest : TeaModel {
        /// <summary>
        /// <para>Lingjun HUB Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-aueyxxsy</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>Authorized Resource Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grant-rule-jaj34d75h01</para>
        /// </summary>
        [NameInMap("GrantRuleId")]
        [Validation(Required=false)]
        public string GrantRuleId { get; set; }

        /// <summary>
        /// <para>Authorized Tenant ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620939556166277</para>
        /// </summary>
        [NameInMap("GrantTenantId")]
        [Validation(Required=false)]
        public string GrantTenantId { get; set; }

        /// <summary>
        /// <para>Authorized Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-jaj34d75h01</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region. This parameter is required.</para>
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
