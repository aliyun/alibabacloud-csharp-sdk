// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PreloadCachesRequest : TeaModel {
        /// <summary>
        /// <para>The files to be prefetched.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<string> Content { get; set; }

        /// <summary>
        /// <para>By default, prefetch requests include the Accept-Encoding:gzip header. If you want a prefetch request to include other headers or implement multi-replica prefetch, you can specify a custom prefetch header by configuring the Headers parameter.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// <para>The website ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
