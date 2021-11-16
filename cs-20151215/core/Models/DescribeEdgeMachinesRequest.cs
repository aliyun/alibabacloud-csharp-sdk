// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesRequest : TeaModel {
        /// <summary>
        /// host name
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// life state
        /// </summary>
        [NameInMap("life_state")]
        [Validation(Required=false)]
        public string LifeState { get; set; }

        /// <summary>
        /// model
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// online state
        /// </summary>
        [NameInMap("online_state")]
        [Validation(Required=false)]
        public string OnlineState { get; set; }

        /// <summary>
        /// page number
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// page size
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
