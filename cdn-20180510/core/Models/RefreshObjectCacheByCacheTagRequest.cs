// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class RefreshObjectCacheByCacheTagRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CacheTag")]
        [Validation(Required=false)]
        public string CacheTag { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
