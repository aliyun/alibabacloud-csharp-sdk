// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset. For more information about how to obtain the dataset name, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect file statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: File statistics are collected. The FileCount and TotalFileSize fields in the Dataset struct are valid.</description></item>
        /// <item><description>false: File statistics are not collected. The FileCount and TotalFileSize fields in the Dataset struct may be incorrect or both 0.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithStatistics")]
        [Validation(Required=false)]
        public bool? WithStatistics { get; set; }

    }

}
