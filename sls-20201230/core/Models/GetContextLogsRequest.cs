// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsRequest : TeaModel {
        /// <summary>
        /// The number of logs that you want to obtain and are generated before the generation time of the start log. Valid values: `(0,100]`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        /// <summary>
        /// The number of logs that you want to obtain and are generated after the generation time of the start log. Valid values: `(0,100]`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        /// <summary>
        /// The unique identifier of the log group to which the start log belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("pack_id")]
        [Validation(Required=false)]
        public string PackId { get; set; }

        /// <summary>
        /// The unique context identifier of the start log in the log group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("pack_meta")]
        [Validation(Required=false)]
        public string PackMeta { get; set; }

        /// <summary>
        /// The type of the data in the Logstore. Set the value to context_log.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
