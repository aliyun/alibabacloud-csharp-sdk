// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class RegisterUdfFunctionRequest : TeaModel {
        /// <summary>
        /// The name of the class that corresponds to the UDF.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// The name of the UDF. In most cases, the name of the UDF is the same as the class name. You can specify a name for the UDF.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The name of the JAR or Python file that corresponds to the UDF.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
