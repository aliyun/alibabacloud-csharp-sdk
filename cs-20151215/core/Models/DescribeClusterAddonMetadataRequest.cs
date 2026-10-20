// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.8.4.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
