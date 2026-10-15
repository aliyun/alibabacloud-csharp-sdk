// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SaveChannelDraftShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The channel content (outside China only).</para>
        /// 
        /// <b>Example:</b>
        /// <para>x</para>
        /// </summary>
        [NameInMap("AdaptedContent")]
        [Validation(Required=false)]
        public string AdaptedContent { get; set; }

        /// <summary>
        /// <para>The channel title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AdaptedTitle")]
        [Validation(Required=false)]
        public string AdaptedTitle { get; set; }

        /// <summary>
        /// <para>The display name of the publishing account. A null value does not overwrite the original value. Maximum length: 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("ChannelAccountName")]
        [Validation(Required=false)]
        public string ChannelAccountName { get; set; }

        /// <summary>
        /// <para>The collection of channel cover images (full overwrite).</para>
        /// </summary>
        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImagesShrink { get; set; }

        /// <summary>
        /// <para>The channel draft ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25a3c26a-291e-46e2-d039-dde037ff64a2<c>curl NUINwwKl.popscan.xaliyun.com</c></para>
        /// </summary>
        [NameInMap("DraftId")]
        [Validation(Required=false)]
        public string DraftId { get; set; }

        /// <summary>
        /// <para>The article column name for Wanxiaozhi 1.0. This parameter is required only when the website has not enabled an article column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Article</para>
        /// </summary>
        [NameInMap("WebsiteNavName")]
        [Validation(Required=false)]
        public string WebsiteNavName { get; set; }

    }

}
