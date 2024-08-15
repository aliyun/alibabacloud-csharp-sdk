// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCharacterSetNameResponseBody : TeaModel {
        /// <summary>
        /// The character sets that are supported.
        /// </summary>
        [NameInMap("CharacterSetNameItems")]
        [Validation(Required=false)]
        public DescribeCharacterSetNameResponseBodyCharacterSetNameItems CharacterSetNameItems { get; set; }
        public class DescribeCharacterSetNameResponseBodyCharacterSetNameItems : TeaModel {
            [NameInMap("CharacterSetName")]
            [Validation(Required=false)]
            public List<string> CharacterSetName { get; set; }

        }

        /// <summary>
        /// The type of the database engine.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
