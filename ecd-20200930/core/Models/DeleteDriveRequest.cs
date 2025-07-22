// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteDriveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dri-aaaa****</para>
        /// </summary>
        [NameInMap("DriveId")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
