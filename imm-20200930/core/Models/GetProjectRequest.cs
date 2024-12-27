// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetProjectRequest : TeaModel {
        /// <summary>
        /// <para>The name of the project. You can obtain the name from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable real-time retrieval of file statistics. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to true, the returned values of FileCount and TotalFileSize in the response are valid.</description></item>
        /// <item><description>If you set the value to false, the returned values of FileCount and TotalFileSize in the response are invalid or equal to 0.</description></item>
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
