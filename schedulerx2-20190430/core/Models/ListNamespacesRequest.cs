// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListNamespacesRequest : TeaModel {
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
