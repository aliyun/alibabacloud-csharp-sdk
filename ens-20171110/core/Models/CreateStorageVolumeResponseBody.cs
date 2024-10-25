// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageVolumeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7030AB96-57CF-1C68-9FEE-D60E547FD79C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of volume IDs.</para>
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public List<string> VolumeId { get; set; }

    }

}
