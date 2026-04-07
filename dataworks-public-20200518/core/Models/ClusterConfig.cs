// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ClusterConfig : TeaModel {
        /// <summary>
        /// <para>The configuration value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;spark.driver.memory&quot;:&quot;1g&quot;}</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the advanced settings of nodes in DataStudio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableOverwrite")]
        [Validation(Required=false)]
        public bool? EnableOverwrite { get; set; }

        /// <summary>
        /// <para>The module in which the cluster is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ide: DataStudio.</description></item>
        /// <item><description>da: DataAnalysis.</description></item>
        /// <item><description>scheduler.auto: Operation Center - auto triggered instances.</description></item>
        /// <item><description>scheduler.backfill: Operation Center - data backfill instances.</description></item>
        /// <item><description>scheduler.test: Operation Center - test instances.</description></item>
        /// <item><description>scheduler.manual: Operation Center - manually triggered instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ide</para>
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

    }

}
