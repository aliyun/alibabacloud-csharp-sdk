// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class MoveAppResourceResponseBody : TeaModel {
        [NameInMap("FailedResourceIds")]
        [Validation(Required=false)]
        public List<string> FailedResourceIds { get; set; }

        [NameInMap("NonExistResourceIds")]
        [Validation(Required=false)]
        public List<string> NonExistResourceIds { get; set; }

        /// <summary>
        /// Migrates one or more resources from an application to another application.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
