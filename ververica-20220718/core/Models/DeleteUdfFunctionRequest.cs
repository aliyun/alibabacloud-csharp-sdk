// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeleteUdfFunctionRequest : TeaModel {
        /// <summary>
        /// The name of the class that corresponds to the UDF.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// The name of the resource that corresponds to the UDF that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
