// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StartReverseWriterRequest : TeaModel {
        /// <summary>
        /// The offset of the Incremental Write module. Specify a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. 
        /// 
        /// > The default value is the offset that is automatically saved by DTS when the task is paused.
        /// </summary>
        [NameInMap("CheckPoint")]
        [Validation(Required=false)]
        public string CheckPoint { get; set; }

        /// <summary>
        /// The ID of the reverse task that was created by calling the CreateReverseDtsJob operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
