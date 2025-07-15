// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class LiveUpstreamQosDataRequest : TeaModel {
        [NameInMap("CdnDomains")]
        [Validation(Required=false)]
        public List<string> CdnDomains { get; set; }

        [NameInMap("CdnIsps")]
        [Validation(Required=false)]
        public List<string> CdnIsps { get; set; }

        [NameInMap("CdnProvinces")]
        [Validation(Required=false)]
        public List<string> CdnProvinces { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("KwaiSidcs")]
        [Validation(Required=false)]
        public List<string> KwaiSidcs { get; set; }

        [NameInMap("KwaiTsc")]
        [Validation(Required=false)]
        public List<int?> KwaiTsc { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UpstreamDomains")]
        [Validation(Required=false)]
        public List<string> UpstreamDomains { get; set; }

    }

}
