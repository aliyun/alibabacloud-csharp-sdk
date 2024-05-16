// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineKeyPathRequest : TeaModel {
        /// <summary>
        /// The name of the event.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        /// <summary>
        /// The ID of the event.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InGroupId")]
        [Validation(Required=false)]
        public int? InGroupId { get; set; }

    }

}
