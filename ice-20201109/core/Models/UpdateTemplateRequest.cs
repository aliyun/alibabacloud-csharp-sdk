// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>参见模板Config文档</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg">http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg</a></para>
        /// </summary>
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>视频添加水印模板</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("PreviewMedia")]
        [Validation(Required=false)]
        public string PreviewMedia { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;,&quot;<b><b><b>cb7db64841b159b4f2ea</b></b></b>&quot;],&quot;audio&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;],&quot;image&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;]}</para>
        /// </summary>
        [NameInMap("RelatedMediaids")]
        [Validation(Required=false)]
        public string RelatedMediaids { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
