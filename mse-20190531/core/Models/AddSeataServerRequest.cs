// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddSeataServerRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// 节点数量
        /// </summary>
        [NameInMap("Replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        /// <summary>
        /// 专有网络ID
        /// </summary>
        [NameInMap("Vpc")]
        [Validation(Required=false)]
        public string Vpc { get; set; }

        [NameInMap("Vswitch")]
        [Validation(Required=false)]
        public string Vswitch { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
