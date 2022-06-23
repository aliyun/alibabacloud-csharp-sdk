// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CommonAddress : TeaModel {
        /// <summary>
        /// 地址
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// zip
        /// </summary>
        [NameInMap("Zip")]
        [Validation(Required=false)]
        public string Zip { get; set; }

    }

}
