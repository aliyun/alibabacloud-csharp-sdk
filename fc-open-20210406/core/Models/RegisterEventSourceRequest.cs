// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class RegisterEventSourceRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the event source.
        /// </summary>
        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        /// <summary>
        /// The version or alias of the service.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
