// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class AdvancePurgeObjectCacheRequest : TeaModel {
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public AdvancePurgeObjectCacheRequestContent Content { get; set; }
        public class AdvancePurgeObjectCacheRequestContent : TeaModel {
            [NameInMap("CacheTags")]
            [Validation(Required=false)]
            public List<string> CacheTags { get; set; }

            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<string> Directories { get; set; }

            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<object> Files { get; set; }

            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            [NameInMap("IgnoreParams")]
            [Validation(Required=false)]
            public List<string> IgnoreParams { get; set; }

            [NameInMap("PurgeAll")]
            [Validation(Required=false)]
            public bool? PurgeAll { get; set; }

        }

        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("Stations")]
        [Validation(Required=false)]
        public string Stations { get; set; }

        [NameInMap("TimeRangeBegin")]
        [Validation(Required=false)]
        public int? TimeRangeBegin { get; set; }

        [NameInMap("TimeRangeEnd")]
        [Validation(Required=false)]
        public int? TimeRangeEnd { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
