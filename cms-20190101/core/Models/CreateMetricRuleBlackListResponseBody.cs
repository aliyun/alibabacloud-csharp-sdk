// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleBlackListResponseBody : TeaModel {
        /// <summary>
        /// The effective scope of the blacklist policy. Valid values:
        /// 
        /// *   USER: The blacklist policy takes effect only for the current Alibaba Cloud account.
        /// 
        /// *   GROUP: The blacklist policy takes effect only for the specified application group. This is the default value.
        /// 
        ///     For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](~~115032~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// For more information about common request parameters, see [Common parameters](~~199331~~).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
