// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class RegisterUdfFunctionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the class that corresponds to the UDF.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orderRank</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The name of the UDF. In most cases, the name of the UDF is the same as the class name. You can specify a name for the UDF.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orderRank</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The name of the JAR or Python file that corresponds to the UDF.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-udf</para>
        /// </summary>
        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
