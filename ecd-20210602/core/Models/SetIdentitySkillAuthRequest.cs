// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class SetIdentitySkillAuthRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically install. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes</description></item>
        /// <item><description>false: no</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public bool? AutoInstall { get; set; }

        /// <summary>
        /// <para>The list of authorized objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Identities")]
        [Validation(Required=false)]
        public List<SetIdentitySkillAuthRequestIdentities> Identities { get; set; }
        public class SetIdentitySkillAuthRequestIdentities : TeaModel {
            /// <summary>
            /// <para>The ID of the authorized object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-av4u9m5ghko26****</para>
            /// </summary>
            [NameInMap("IdentityId")]
            [Validation(Required=false)]
            public string IdentityId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The operation type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SET_AUTH</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The skill channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENTERPRISE: enterprise edition</description></item>
        /// <item><description>BUSINESS: business edition</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("SkillChannel")]
        [Validation(Required=false)]
        public string SkillChannel { get; set; }

        /// <summary>
        /// <para>The list of skill IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SkillIds")]
        [Validation(Required=false)]
        public List<string> SkillIds { get; set; }

    }

}
