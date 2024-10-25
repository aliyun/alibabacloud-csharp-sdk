// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateColdStorageInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs_2zeth2gf4i83e578t</para>
        /// </summary>
        [NameInMap("ColdStorageInstanceId")]
        [Validation(Required=false)]
        public string ColdStorageInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6EBB4ED-D12F-5F49-824C-9DD9C0EC4CF2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
