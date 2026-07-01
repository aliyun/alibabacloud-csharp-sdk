// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UdfFunction : TeaModel {
        /// <summary>
        /// <para>The class name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFunctionTest</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFunction</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The UDF artifact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>udfCollection.jar</para>
        /// </summary>
        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
