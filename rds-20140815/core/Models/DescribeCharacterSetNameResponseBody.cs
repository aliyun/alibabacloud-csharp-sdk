// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCharacterSetNameResponseBody : TeaModel {
        [NameInMap("CharacterSetNameItems")]
        [Validation(Required=false)]
        public DescribeCharacterSetNameResponseBodyCharacterSetNameItems CharacterSetNameItems { get; set; }
        public class DescribeCharacterSetNameResponseBodyCharacterSetNameItems : TeaModel {
            [NameInMap("CharacterSetName")]
            [Validation(Required=false)]
            public List<string> CharacterSetName { get; set; }

        }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
