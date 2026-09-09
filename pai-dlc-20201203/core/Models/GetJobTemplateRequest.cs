// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobTemplateRequest : TeaModel {
        /// <summary>
        /// <para>If this parameter is not specified, the default version is returned. If a specific number is specified, the corresponding version is returned. If all is specified, all versions are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
