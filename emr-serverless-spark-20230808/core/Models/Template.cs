// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Template : TeaModel {
        /// <summary>
        /// <para>The business ID of the Spark task template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template-example-****</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The creator UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150978934701****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public long? Creator { get; set; }

        /// <summary>
        /// <para>The display version of the Spark engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-4.1.1</para>
        /// </summary>
        [NameInMap("displaySparkVersion")]
        [Validation(Required=false)]
        public string DisplaySparkVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether Fusion is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-10T02:02:41.000+00:00</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The last updated time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-10T02:02:41.000+00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Specifies whether the template is the default template.</para>
        /// </summary>
        [NameInMap("isDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The last updater UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150978934701****</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public long? Modifier { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark-task-template</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Spark Conf</para>
        /// </summary>
        [NameInMap("sparkConf")]
        [Validation(Required=false)]
        public List<SparkConf> SparkConf { get; set; }

        /// <summary>
        /// <para>The number of Spark driver cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sparkDriverCores")]
        [Validation(Required=false)]
        public int? SparkDriverCores { get; set; }

        /// <summary>
        /// <para>The Spark driver memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("sparkDriverMemory")]
        [Validation(Required=false)]
        public long? SparkDriverMemory { get; set; }

        /// <summary>
        /// <para>The number of Spark executor cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sparkExecutorCores")]
        [Validation(Required=false)]
        public int? SparkExecutorCores { get; set; }

        /// <summary>
        /// <para>The Spark executor memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("sparkExecutorMemory")]
        [Validation(Required=false)]
        public long? SparkExecutorMemory { get; set; }

        /// <summary>
        /// <para>The Spark log level.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("sparkLogLevel")]
        [Validation(Required=false)]
        public string SparkLogLevel { get; set; }

        /// <summary>
        /// <para>The Spark log path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://your_bucket/path/to/your/log</para>
        /// </summary>
        [NameInMap("sparkLogPath")]
        [Validation(Required=false)]
        public string SparkLogPath { get; set; }

        /// <summary>
        /// <para>The Spark internal release version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-4.1.1</para>
        /// </summary>
        [NameInMap("sparkVersion")]
        [Validation(Required=false)]
        public string SparkVersion { get; set; }

        /// <summary>
        /// <para>The templatetype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TASK</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
