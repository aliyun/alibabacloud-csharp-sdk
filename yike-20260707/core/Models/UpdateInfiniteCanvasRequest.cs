// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class UpdateInfiniteCanvasRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the infinite canvas.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>canvas_gesad*</para>
        /// </summary>
        [NameInMap("CanvasId")]
        [Validation(Required=false)]
        public string CanvasId { get; set; }

        /// <summary>
        /// <para>The cover URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84ec412603784c04a00c737c71d86dfd</para>
        /// </summary>
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <para>The project title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
