// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateKyuubiServiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2c8g</para>
        /// </summary>
        [NameInMap("computeInstance")]
        [Validation(Required=false)]
        public string ComputeInstance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;key\&quot;:\&quot;kyuubi.engine.share.level\&quot;,\&quot;value\&quot;:\&quot;USER\&quot;}]</para>
        /// </summary>
        [NameInMap("kyuubiConfigs")]
        [Validation(Required=false)]
        public string KyuubiConfigs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.9.2-0.0.2</para>
        /// </summary>
        [NameInMap("kyuubiReleaseVersion")]
        [Validation(Required=false)]
        public string KyuubiReleaseVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev_serverless_spark</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("publicEndpointEnabled")]
        [Validation(Required=false)]
        public bool? PublicEndpointEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev_queue</para>
        /// </summary>
        [NameInMap("queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esr-4.6.0 (Spark 3.5.2, Scala 2.12)</para>
        /// </summary>
        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;key\&quot;:\&quot;spark.app.name\&quot;,\&quot;value\&quot;:\&quot;test\&quot;}]</para>
        /// </summary>
        [NameInMap("sparkConfigs")]
        [Validation(Required=false)]
        public string SparkConfigs { get; set; }

    }

}
