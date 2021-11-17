// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class Region : TeaModel {
        /// <summary>
        /// 城市
        /// </summary>
        [NameInMap("RegionCity")]
        [Validation(Required=false)]
        public string RegionCity { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        /// <summary>
        /// 州省
        /// </summary>
        [NameInMap("RegionState")]
        [Validation(Required=false)]
        public string RegionState { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [NameInMap("ServiceUrl")]
        [Validation(Required=false)]
        public string ServiceUrl { get; set; }

    }

}
