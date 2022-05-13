// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateVGroupRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("PrimaryUser")]
        [Validation(Required=false)]
        public string PrimaryUser { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("SeataServerUniqueId")]
        [Validation(Required=false)]
        public string SeataServerUniqueId { get; set; }

    }

}
