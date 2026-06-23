// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PreloadCachesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The prefetch objects.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The default header carried in a prefetch request is Accept-Encoding:gzip. If you want the prefetch request to carry other headers or implement multi-copy prefetching, use this parameter to specify custom prefetch headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string HeadersShrink { get; set; }

        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
