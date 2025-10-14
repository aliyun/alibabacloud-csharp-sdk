// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveSDGsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The IDs of SDG.</para>
        /// </summary>
        [NameInMap("SdgIds")]
        [Validation(Required=false)]
        public List<string> SdgIds { get; set; }

    }

}
