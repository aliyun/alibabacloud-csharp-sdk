// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteStorageVolumeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the volume.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sv-***</para>
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public string VolumeId { get; set; }

    }

}
