// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BTemplateTag : TeaModel {
        /// <summary>
        /// <para>The ID of the template build associated with the tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-build-id</para>
        /// </summary>
        [NameInMap("buildID")]
        [Validation(Required=false)]
        public string BuildID { get; set; }

        /// <summary>
        /// <para>The creation time of the tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The name of the template tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
