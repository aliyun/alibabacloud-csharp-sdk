// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetTestcaseListRequest : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        [NameInMap("directoryIdentifier")]
        [Validation(Required=false)]
        public string DirectoryIdentifier { get; set; }

        [NameInMap("maxResult")]
        [Validation(Required=false)]
        public string MaxResult { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

    }

}
