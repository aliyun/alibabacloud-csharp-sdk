// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeAccountStatResponseBody : TeaModel {
        [NameInMap("GroupLimit")]
        [Validation(Required=false)]
        public long? GroupLimit { get; set; }

        [NameInMap("GroupNum")]
        [Validation(Required=false)]
        public long? GroupNum { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateLimit")]
        [Validation(Required=false)]
        public long? TemplateLimit { get; set; }

        [NameInMap("TemplateNum")]
        [Validation(Required=false)]
        public long? TemplateNum { get; set; }

    }

}
