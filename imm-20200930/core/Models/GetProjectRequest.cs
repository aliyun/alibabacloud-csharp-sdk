// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetProjectRequest : TeaModel {
        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">创建项目</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect file statistics. Default value: false, which indicates that file statistics are not collected.</para>
        /// <list type="bullet">
        /// <item><description><para>File statistics are collected. The FileCount and TotalFileSize values in the returned Project struct are valid.</para>
        /// </description></item>
        /// <item><description><para>File statistics are not collected. The FileCount and TotalFileSize values in the returned Project struct may be inaccurate or both may be 0.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Only files in datasets created before December 20, 2025 can be counted..</para>
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
