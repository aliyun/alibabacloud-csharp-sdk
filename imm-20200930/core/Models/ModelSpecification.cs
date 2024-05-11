// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ModelSpecification : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public Spec Spec { get; set; }

    }

}
