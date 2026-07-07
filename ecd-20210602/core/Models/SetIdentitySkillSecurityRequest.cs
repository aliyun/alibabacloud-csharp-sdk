// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class SetIdentitySkillSecurityRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the skill installation permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The list of resource information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IdentityIds")]
        [Validation(Required=false)]
        public List<SetIdentitySkillSecurityRequestIdentityIds> IdentityIds { get; set; }
        public class SetIdentitySkillSecurityRequestIdentityIds : TeaModel {
            /// <summary>
            /// <para>The resource information ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-b9ej3xiok4tjbgf9x</para>
            /// </summary>
            [NameInMap("IdentityId")]
            [Validation(Required=false)]
            public string IdentityId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The skill channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENTERPRISE: enterprise edition.</description></item>
        /// <item><description>BUSINESS: business edition.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("SkillChannel")]
        [Validation(Required=false)]
        public string SkillChannel { get; set; }

    }

}
