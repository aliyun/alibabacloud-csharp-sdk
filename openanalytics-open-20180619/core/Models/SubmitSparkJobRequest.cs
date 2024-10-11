// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class SubmitSparkJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;name&quot;: &quot;SparkPi&quot;,     &quot;file&quot;: &quot;local:///tmp/spark-examples.jar&quot;,     &quot;className&quot;: &quot;org.apache.spark.examples.SparkPi&quot;,     &quot;args&quot;: [         &quot;100&quot;     ],     &quot;conf&quot;: {         &quot;spark.driver.resourceSpec&quot;: &quot;medium&quot;,         &quot;spark.executor.instances&quot;: 5,         &quot;spark.executor.resourceSpec&quot;: &quot;medium&quot;     } }</para>
        /// </summary>
        [NameInMap("ConfigJson")]
        [Validation(Required=false)]
        public string ConfigJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCluster</para>
        /// </summary>
        [NameInMap("VcName")]
        [Validation(Required=false)]
        public string VcName { get; set; }

    }

}
