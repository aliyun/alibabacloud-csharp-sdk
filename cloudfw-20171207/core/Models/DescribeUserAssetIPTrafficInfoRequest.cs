// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAssetIPTrafficInfoRequest : TeaModel {
        /// <summary>
        /// 资产IP
        /// </summary>
        [NameInMap("AssetIP")]
        [Validation(Required=false)]
        public string AssetIP { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [NameInMap("TrafficTime")]
        [Validation(Required=false)]
        public string TrafficTime { get; set; }

    }

}
