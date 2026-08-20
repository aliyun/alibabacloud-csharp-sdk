// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Locales")]
        [Validation(Required=false)]
        public List<GetSkillResponseBodyLocales> Locales { get; set; }
        public class GetSkillResponseBodyLocales : TeaModel {
            [NameInMap("EnValue")]
            [Validation(Required=false)]
            public string EnValue { get; set; }

            [NameInMap("OriginalValue")]
            [Validation(Required=false)]
            public string OriginalValue { get; set; }

            [NameInMap("ZhValue")]
            [Validation(Required=false)]
            public string ZhValue { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>13FE89A5-C036-56BF-A0FF-A31C59819FD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The set of connection types required by the Skill.</para>
        /// </summary>
        [NameInMap("RequiredConnections")]
        [Validation(Required=false)]
        public List<string> RequiredConnections { get; set; }

        /// <summary>
        /// <para>The security scan status of the source file.</para>
        /// </summary>
        [NameInMap("SecurityScanStatus")]
        [Validation(Required=false)]
        public string SecurityScanStatus { get; set; }

        /// <summary>
        /// <para>The Skill description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create new skills, modify and improve existing skills, and measure skill performance.</para>
        /// </summary>
        [NameInMap("SkillDescription")]
        [Validation(Required=false)]
        public string SkillDescription { get; set; }

        /// <summary>
        /// <para>The Skill display name.</para>
        /// </summary>
        [NameInMap("SkillDisplayName")]
        [Validation(Required=false)]
        public string SkillDisplayName { get; set; }

        /// <summary>
        /// <para>Skill ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-xxxxx</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The set of Skill labels.</para>
        /// </summary>
        [NameInMap("SkillLabels")]
        [Validation(Required=false)]
        public List<string> SkillLabels { get; set; }

        /// <summary>
        /// <para>The Skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-creator</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The ID of the SkillSpace to which the Skill belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-xxxxx</para>
        /// </summary>
        [NameInMap("SkillSpaceId")]
        [Validation(Required=false)]
        public string SkillSpaceId { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
