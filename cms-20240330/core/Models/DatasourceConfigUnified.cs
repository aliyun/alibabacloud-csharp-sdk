// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DatasourceConfigUnified : TeaModel {
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
