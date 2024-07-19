// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceLabelRequest : TeaModel {
        /// <summary>
        /// The service tags that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<string> Keys { get; set; }

    }

}
