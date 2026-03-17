// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class JobDriver : TeaModel {
        /// <summary>
        /// <para>The configurations of SparkSubmit.</para>
        /// </summary>
        [NameInMap("sparkSubmit")]
        [Validation(Required=false)]
        public JobDriverSparkSubmit SparkSubmit { get; set; }
        public class JobDriverSparkSubmit : TeaModel {
            /// <summary>
            /// <para>The main program of Spark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/path/to/entrypoint.jar</para>
            /// </summary>
            [NameInMap("entryPoint")]
            [Validation(Required=false)]
            public string EntryPoint { get; set; }

            /// <summary>
            /// <para>The parameters related to the main program of Spark.</para>
            /// </summary>
            [NameInMap("entryPointArguments")]
            [Validation(Required=false)]
            public List<string> EntryPointArguments { get; set; }

            /// <summary>
            /// <para>The command-line parameter of SparkSubmit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--conf spark.app.name=test</para>
            /// </summary>
            [NameInMap("sparkSubmitParameters")]
            [Validation(Required=false)]
            public string SparkSubmitParameters { get; set; }

        }

    }

}
