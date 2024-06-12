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
        /// For more information about how to obtain the ID of the account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The ID of the remediation template. Separate multiple remediation template IDs with commas (,).
        /// 
        /// For more information about how to obtain the ID of a remediation template, see [ListAggregateRemediations](https://help.aliyun.com/document_detail/270036.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RemediationIds")]
        [Validation(Required=false)]
        public string RemediationIds { get; set; }

    }

}
