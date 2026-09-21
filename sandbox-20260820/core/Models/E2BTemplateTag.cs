// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BTemplateTag : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>b7e21c05-****</para>
        /// </summary>
        [NameInMap("buildID")]
        [Validation(Required=false)]
        public string BuildID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-20T08:35:12Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
