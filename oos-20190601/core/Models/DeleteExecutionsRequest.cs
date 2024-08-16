// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteExecutionsRequest : TeaModel {
        /// <summary>
        /// The execution IDs.
        /// 
        /// You can specify multiple execution IDs in a JSON array in the format of `["xxxxxxxxx", "yyyyyyyyy", ... "zzzzzzzzz"]`. You can specify up to 100 execution IDs at a time. Separate multiple IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExecutionIds")]
        [Validation(Required=false)]
        public string ExecutionIds { get; set; }

        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
