// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAttachedMediaInfosRequest : TeaModel {
        /// <summary>
        /// The new information about auxiliary media assets. You can modify the information about up to 20 auxiliary media assets at a time. For more information, see the **UpdateContent** section of this topic.
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
