// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetUserConfigResponseBody : TeaModel {
        /// <summary>
        /// 当前版本
        /// </summary>
        [NameInMap("CurrentFeatureVersion")]
        [Validation(Required=false)]
        public string CurrentFeatureVersion { get; set; }

        /// <summary>
        /// 是否启用v2功能
        /// </summary>
        [NameInMap("EnableEmrCluster")]
        [Validation(Required=false)]
        public bool? EnableEmrCluster { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否显示特价版功能
        /// </summary>
        [NameInMap("UseOnSaleVersion")]
        [Validation(Required=false)]
        public bool? UseOnSaleVersion { get; set; }

        /// <summary>
        /// 是否使用团队版功能（v21）
        /// </summary>
        [NameInMap("UseV21Feature")]
        [Validation(Required=false)]
        public bool? UseV21Feature { get; set; }

    }

}
