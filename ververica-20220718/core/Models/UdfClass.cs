// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UdfClass : TeaModel {
        /// <summary>
        /// <para>The name of the class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myfunctionTest</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The type of the class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UDF_TYPE_TABLE_AGGREGATE</para>
        /// </summary>
        [NameInMap("classType")]
        [Validation(Required=false)]
        public string ClassType { get; set; }

        /// <summary>
        /// <para>The list of UDF names.</para>
        /// </summary>
        [NameInMap("functionNames")]
        [Validation(Required=false)]
        public List<string> FunctionNames { get; set; }

        /// <summary>
        /// <para>The name of the UDF JAR file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>udfCollection.jar</para>
        /// </summary>
        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
