// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduEmbed20240101.Models
{
    public class CreateLabSessionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LabId")]
        [Validation(Required=false)]
        public long? LabId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RamAccountId")]
        [Validation(Required=false)]
        public long? RamAccountId { get; set; }

    }

}
