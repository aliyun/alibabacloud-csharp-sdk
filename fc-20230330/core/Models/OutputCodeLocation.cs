// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class OutputCodeLocation : TeaModel {
        /// <summary>
        /// <para>The address of the code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xyz.oss-cn-shanghai.aliyuncs.com/xxx/xxx/xxx">https://xyz.oss-cn-shanghai.aliyuncs.com/xxx/xxx/xxx</a></para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The type of the code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("repositoryType")]
        [Validation(Required=false)]
        public string RepositoryType { get; set; }

    }

}
