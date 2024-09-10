// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteLogMonitorRequest : TeaModel {
        /// <summary>
        /// The ID returned by Log Service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public long? LogId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
