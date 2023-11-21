// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetExampleQueryRequest : TeaModel {
        /// <summary>
        /// The ID of the template.
        /// 
        /// >  You can call the [ListExampleQueries](~~ListExampleQueries~~) operation to obtain the template ID.
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

    }

}
