// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class TensorboardDataSourceSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlcJobName</para>
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://xxxxx/tensorboard/run1</para>
        /// </summary>
        [NameInMap("FullSummaryPath")]
        [Validation(Required=false)]
        public string FullSummaryPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d-vf2fdhxxxxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlcJobName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>datasource</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/tensorboard/run1</para>
        /// </summary>
        [NameInMap("SummaryPath")]
        [Validation(Required=false)]
        public string SummaryPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://.oss-cn-shanghai-finance-1.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
