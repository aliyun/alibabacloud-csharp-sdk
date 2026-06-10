// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateSkillRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/30516570">https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/30516570</a></para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("SkillDescription")]
        [Validation(Required=false)]
        public string SkillDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;category:frontend-development&quot;]</para>
        /// </summary>
        [NameInMap("SkillLabels")]
        [Validation(Required=false)]
        public List<string> SkillLabels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-111111</para>
        /// </summary>
        [NameInMap("SkillSpaceId")]
        [Validation(Required=false)]
        public string SkillSpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s-11111</para>
        /// </summary>
        [NameInMap("SourceSkillId")]
        [Validation(Required=false)]
        public string SourceSkillId { get; set; }

        /// <summary>
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
