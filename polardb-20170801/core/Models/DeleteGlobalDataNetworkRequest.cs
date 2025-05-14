// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteGlobalDataNetworkRequest : TeaModel {
        /// <summary>
        /// <para>GDN ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-xxx</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

    }

}
