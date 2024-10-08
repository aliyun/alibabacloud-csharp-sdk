// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PreloadCachesShrinkRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string HeadersShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
