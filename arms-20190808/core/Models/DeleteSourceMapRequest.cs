// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSourceMapRequest : TeaModel {
        /// <summary>
        /// The IDs of the SourceMap files.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FidList")]
        [Validation(Required=false)]
        public List<string> FidList { get; set; }

        /// <summary>
        /// The process identifier (PID) of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
