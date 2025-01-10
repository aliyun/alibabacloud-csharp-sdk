// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class DeleteVccGrantRuleRequest : TeaModel {
        /// <summary>
        /// <para>Lingjun HUB ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>Authorization Entry ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grant-rule-jaj34d75h01</para>
        /// </summary>
        [NameInMap("GrantRuleId")]
        [Validation(Required=false)]
        public string GrantRuleId { get; set; }

        /// <summary>
        /// <para>Network Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-jaj34d75h01</para>
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
