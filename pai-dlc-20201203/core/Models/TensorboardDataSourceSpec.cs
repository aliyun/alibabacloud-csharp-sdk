// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class TensorboardDataSourceSpec : TeaModel {
        /// <summary>
        /// <para>The file type that corresponds to the URI in the dataset configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The directory prefix of the dataset in the TensorBoard task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlcJobName</para>
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// <para>The full summary path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://xxxxx/tensorboard/run1</para>
        /// </summary>
        [NameInMap("FullSummaryPath")]
        [Validation(Required=false)]
        public string FullSummaryPath { get; set; }

        /// <summary>
        /// <para>The ID of the dataset configurations. In most cases, the ID of the dataset configurations is the ID of a dataset or task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-vf2fdhxxxxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the dataset configurations. In most cases, the name of the dataset configurations is the name of a dataset or task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlcJobName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The dataset type.</para>
        /// <list type="bullet">
        /// <item><description>datasource: configure a dataset based on the dataset type.</description></item>
        /// <item><description>dlcjob: configure a dataset based on the task type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>datasource</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The summary path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/tensorboard/run1</para>
        /// </summary>
        [NameInMap("SummaryPath")]
        [Validation(Required=false)]
        public string SummaryPath { get; set; }

        /// <summary>
        /// <para>The file system URI in the dataset configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://.oss-cn-shanghai-finance-1.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
