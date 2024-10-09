// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetUdfArtifactsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the JAR or Python file that corresponds to the UDF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-udf</para>
        /// </summary>
        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
