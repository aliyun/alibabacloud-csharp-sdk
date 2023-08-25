// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class StartSparkSQLEngineRequest : TeaModel {
        /// <summary>
        /// The configuration that is required to start the Spark SQL engine. Specify this value in the JSON format. For more information, see [Conf configuration parameters](~~471203~~).
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The Object Storage Service (OSS) paths of third-party JAR packages that are required to start the Spark SQL engine. Separate multiple OSS paths with commas (,).
        /// </summary>
        [NameInMap("Jars")]
        [Validation(Required=false)]
        public string Jars { get; set; }

        /// <summary>
        /// The maximum number of executors that are required to execute SQL statements. Valid values: 1 to 2000. If this value exceeds the total number of executes that are supported by the resource group, the Spark SQL engine fails to be started.
        /// </summary>
        [NameInMap("MaxExecutor")]
        [Validation(Required=false)]
        public long? MaxExecutor { get; set; }

        /// <summary>
        /// The minimum number of executors that are required to execute SQL statements. Valid values: 0 to 2000. A value of 0 indicates that no executors are permanent if no SQL statements are executed. If this value exceeds the total number of executes that are supported by the resource group, the Spark SQL engine fails to be started. The value must be less than the value of MaxExecutor.
        /// </summary>
        [NameInMap("MinExecutor")]
        [Validation(Required=false)]
        public long? MinExecutor { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The maximum number of slots that are required to maintain Spark sessions for executing SQL statements. Valid values: 1 to 500.
        /// </summary>
        [NameInMap("SlotNum")]
        [Validation(Required=false)]
        public long? SlotNum { get; set; }

    }

}
