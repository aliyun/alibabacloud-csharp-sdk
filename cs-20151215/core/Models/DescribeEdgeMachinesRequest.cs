// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesRequest : TeaModel {
        /// <summary>
        /// The `hostname` of the cloud-native box.
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// The lifecycle status.
        /// </summary>
        [NameInMap("life_state")]
        [Validation(Required=false)]
        public string LifeState { get; set; }

        /// <summary>
        /// The type of cloud-native box.
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// The status of the cloud-native box. Valid values:
        /// 
        /// *   `offline`
        /// *   `online`
        /// </summary>
        [NameInMap("online_state")]
        [Validation(Required=false)]
        public string OnlineState { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
