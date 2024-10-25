// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1.18.8</para>
        /// </summary>
        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mycluster-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
