// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class SwitchHbaseHaSlbRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BdsId")]
        [Validation(Required=false)]
        public string BdsId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HaId")]
        [Validation(Required=false)]
        public string HaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HaTypes")]
        [Validation(Required=false)]
        public string HaTypes { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HbaseType")]
        [Validation(Required=false)]
        public string HbaseType { get; set; }

    }

}
