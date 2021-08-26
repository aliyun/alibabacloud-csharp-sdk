// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateBindingRequest : TeaModel {
        /// <summary>
        /// ProjectName
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// DatasetName
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
