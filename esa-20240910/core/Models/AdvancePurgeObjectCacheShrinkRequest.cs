// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class AdvancePurgeObjectCacheShrinkRequest : TeaModel {
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

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
