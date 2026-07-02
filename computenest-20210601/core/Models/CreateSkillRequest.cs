// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateSkillRequest : TeaModel {
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
        /// <para>The OSS URL of the Skill package to upload. This parameter is required when SourceType is set to UPLOAD.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/30516570">https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/30516570</a></para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        /// <summary>
        /// <para>The Skill description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("SkillDescription")]
        [Validation(Required=false)]
        public string SkillDescription { get; set; }

        [NameInMap("SkillDisplayName")]
        [Validation(Required=false)]
        public string SkillDisplayName { get; set; }

        /// <summary>
        /// <para>The Skill labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;category:frontend-development&quot;]</para>
        /// </summary>
        [NameInMap("SkillLabels")]
        [Validation(Required=false)]
        public List<string> SkillLabels { get; set; }

        /// <summary>
        /// <para>The Skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The ID of the SkillSpace to which the Skill belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-111111</para>
        /// </summary>
        [NameInMap("SkillSpaceId")]
        [Validation(Required=false)]
        public string SkillSpaceId { get; set; }

        /// <summary>
        /// <para>The public Skill ID. This parameter is required when SourceType is set to COPY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-11111</para>
        /// </summary>
        [NameInMap("SourceSkillId")]
        [Validation(Required=false)]
        public string SourceSkillId { get; set; }

        /// <summary>
        /// <para>The source type used when creating the Skill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COPY</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
