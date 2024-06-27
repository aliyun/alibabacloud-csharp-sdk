// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeFieldListRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        [NameInMap("inputs")]
        [Validation(Required=false)]
        public string Inputs { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

    }

}
