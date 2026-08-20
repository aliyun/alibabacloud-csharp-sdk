// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class UpdateSkillRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The value of <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Required when SourceType is set to UPLOAD. The OSS URL of the skill package to upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/skill-creator1.zip">https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/skill-creator1.zip</a></para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        /// <summary>
        /// <para>The collection of connection types required by the skill.</para>
        /// </summary>
        [NameInMap("RequiredConnections")]
        [Validation(Required=false)]
        public List<string> RequiredConnections { get; set; }

        /// <summary>
        /// <para>The description of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create new skills.</para>
        /// </summary>
        [NameInMap("SkillDescription")]
        [Validation(Required=false)]
        public string SkillDescription { get; set; }

        [NameInMap("SkillDisplayName")]
        [Validation(Required=false)]
        public string SkillDisplayName { get; set; }

        /// <summary>
        /// <para>The ID of the skill to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-xxxxx</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The labels of the skill.</para>
        /// </summary>
        [NameInMap("SkillLabels")]
        [Validation(Required=false)]
        public List<string> SkillLabels { get; set; }

        /// <summary>
        /// <para>The name of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-creator</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>Required when SourceType is set to COPY. The ID of the public skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-xxxxx</para>
        /// </summary>
        [NameInMap("SourceSkillId")]
        [Validation(Required=false)]
        public string SourceSkillId { get; set; }

        /// <summary>
        /// <para>The source type for updating the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COPY</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
