// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DeleteNetworkPathRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of network paths.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkPathIds")]
        [Validation(Required=false)]
        public List<string> NetworkPathIds { get; set; }

        /// <summary>
        /// <para>The region ID of the network path that you want to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
