// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetLiveDomainStatusRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 直播域名列表
        /// </summary>
        [NameInMap("LiveDomainList")]
        [Validation(Required=false)]
        public List<string> LiveDomainList { get; set; }

        /// <summary>
        /// 直播域名类型，推流域名: push, 拉流域名: pull, 回放域名: palyback
        /// </summary>
        [NameInMap("LiveDomainType")]
        [Validation(Required=false)]
        public string LiveDomainType { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
