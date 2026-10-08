// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetProjectRequest : TeaModel {
        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect file statistics. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>true: File statistics are collected. The FileCount and TotalFileSize fields in the Project struct are accurate and valid.</description></item>
        /// <item><description>false: File statistics are not collected. The FileCount and TotalFileSize fields in the Project struct may be inaccurate or both be 0.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: File statistics are supported only for datasets created before December 20, 2025.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithStatistics")]
        [Validation(Required=false)]
        public bool? WithStatistics { get; set; }

    }

}
