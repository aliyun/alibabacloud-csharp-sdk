// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateRemediationsRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// You can call the [ListAggregators](~~255797~~) operation to obtain the account group ID.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The ID of the remediation setting. If you want to specify multiple IDs, separate them with commas (,).
        /// 
        /// You can call the [ListAggregateRemediations](~~270036~~) operation to obtain the remediation setting ID.
        /// </summary>
        [NameInMap("RemediationIds")]
        [Validation(Required=false)]
        public string RemediationIds { get; set; }

    }

}
