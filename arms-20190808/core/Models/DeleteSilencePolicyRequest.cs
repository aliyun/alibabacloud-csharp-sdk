// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSilencePolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the silence policy.
        /// 
        /// For more information about how to obtain the ID of a silence policy, see [ListSilencePolicies](https://help.aliyun.com/document_detail/2612383.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
