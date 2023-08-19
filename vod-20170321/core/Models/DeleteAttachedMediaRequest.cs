// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAttachedMediaRequest : TeaModel {
        /// <summary>
        /// The list of auxiliary media asset IDs.
        /// 
        /// *   Separate multiple IDs with commas (,).
        /// *   A maximum of 20 IDs can be specified.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
