// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class ListRouteRuleRequest : TeaModel {
        [NameInMap("BizChainName")]
        [Validation(Required=false)]
        public string BizChainName { get; set; }

        [NameInMap("ChainUpMode")]
        [Validation(Required=false)]
        public string ChainUpMode { get; set; }

        [NameInMap("DeviceGroupName")]
        [Validation(Required=false)]
        public string DeviceGroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
