// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkDefinitionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The common definitions of Spark applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SQLTemplateExample&quot;: &quot;-- Here is just an example of SparkSQL. Modify the content and run your spark program.
        /// conf spark.driver.resourceSpec=medium;
        /// conf spark.executor.instances=2;
        /// conf spark.executor.resourceSpec=medium;
        /// conf spark.app.name=Spark SQL Test;
        /// conf spark.adb.connectors=oss;</para>
        /// <para>-- Here are your sql statements
        /// show databases;&quot;,
        ///                  &quot;BatchTemplateExample&quot;: &quot;{
        ///     &quot;comments&quot;: [
        ///         &quot;-- Here is just an example of SparkPi. Modify the content and run your spark program.&quot;
        ///     ],
        ///     &quot;args&quot;: [&quot;1000&quot;],
        ///   &quot;file&quot;:&quot;local:///tmp/spark-examples.jar&quot;,
        ///     &quot;name&quot;: &quot;SparkPi&quot;,
        ///     &quot;className&quot;: &quot;org.apache.spark.examples.SparkPi&quot;,
        ///     &quot;conf&quot;: {      &quot;spark.driver.resourceSpec&quot;: &quot;medium&quot;,
        ///         &quot;spark.executor.instances&quot;: 2,
        ///         &quot;spark.executor.resourceSpec&quot;: &quot;medium&quot;
        ///     }
        /// }&quot;</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
