/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AddAutoCcBlacklistRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Blacklist")]
        [Validation(Required=false)]
        public string Blacklist { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
