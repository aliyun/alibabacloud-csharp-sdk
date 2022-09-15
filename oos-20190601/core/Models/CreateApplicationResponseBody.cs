// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateApplicationResponseBody : TeaModel {
        [NameInMap("Application")]
        [Validation(Required=false)]
        public CreateApplicationResponseBodyApplication Application { get; set; }
        public class CreateApplicationResponseBodyApplication : TeaModel {
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
