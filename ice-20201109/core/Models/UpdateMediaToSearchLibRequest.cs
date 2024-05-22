// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaToSearchLibRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MsgBody")]
        [Validation(Required=false)]
        public string MsgBody { get; set; }

        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
