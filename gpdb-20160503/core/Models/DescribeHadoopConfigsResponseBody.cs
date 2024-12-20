// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHadoopConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the configuration file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hdfs-site</description></item>
        /// <item><description>core-site</description></item>
        /// <item><description>yarn-site</description></item>
        /// <item><description>mapred-site</description></item>
        /// <item><description>hive-site</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs-site</para>
        /// </summary>
        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The configuration value.</para>
        /// 
        /// <b>Example:</b>
        /// <?xml version="1.0"?>
        /// <configuration>
        ///     <property>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
