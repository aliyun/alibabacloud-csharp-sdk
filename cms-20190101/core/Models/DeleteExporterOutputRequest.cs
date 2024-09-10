// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteExporterOutputRequest : TeaModel {
        /// <summary>
        /// The name of the configuration set.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestName")]
        [Validation(Required=false)]
        public string DestName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
