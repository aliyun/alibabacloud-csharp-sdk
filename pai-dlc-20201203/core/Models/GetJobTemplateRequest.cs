// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The version number. If you leave this parameter empty, the default version is returned. If you specify a number, the specified version is returned. If you specify all, all versions are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
