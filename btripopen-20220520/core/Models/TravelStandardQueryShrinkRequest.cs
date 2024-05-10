// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardQueryShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("from_group")]
        [Validation(Required=false)]
        public bool? FromGroup { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("rule_code")]
        [Validation(Required=false)]
        public long? RuleCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("service_type_list")]
        [Validation(Required=false)]
        public string ServiceTypeListShrink { get; set; }

    }

}
