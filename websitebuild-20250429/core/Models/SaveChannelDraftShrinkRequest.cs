// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SaveChannelDraftShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content of the channel (outside China only).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Introduces the main features and usage of the website</para>
        /// </summary>
        [NameInMap("AdaptedContent")]
        [Validation(Required=false)]
        public string AdaptedContent { get; set; }

        /// <summary>
        /// <para>The title of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Website features and user guide</para>
        /// </summary>
        [NameInMap("AdaptedTitle")]
        [Validation(Required=false)]
        public string AdaptedTitle { get; set; }

        /// <summary>
        /// <para>The display name of the publishing account. If this parameter is left empty, the original value is not overwritten. Maximum length: 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample publishing account</para>
        /// </summary>
        [NameInMap("ChannelAccountName")]
        [Validation(Required=false)]
        public string ChannelAccountName { get; set; }

        /// <summary>
        /// <para>The collection of cover images for the channel. This parameter overwrites all existing cover images.</para>
        /// </summary>
        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImagesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the channel draft.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25a3c26a-291e-46e2-d039-dde037ff64a2<c>curl NUINwwKl.popscan.xaliyun.com</c></para>
        /// </summary>
        [NameInMap("DraftId")]
        [Validation(Required=false)]
        public string DraftId { get; set; }

        /// <summary>
        /// <para>The name of the article column in Wanxiaozhi 1.0. This parameter is required only when the article column is not enabled for the website.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Article</para>
        /// </summary>
        [NameInMap("WebsiteNavName")]
        [Validation(Required=false)]
        public string WebsiteNavName { get; set; }

    }

}
