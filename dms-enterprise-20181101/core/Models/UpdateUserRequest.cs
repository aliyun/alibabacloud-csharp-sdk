// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// The maximum number of queries that can be performed each day.
        /// </summary>
        [NameInMap("MaxExecuteCount")]
        [Validation(Required=false)]
        public long? MaxExecuteCount { get; set; }

        /// <summary>
        /// The maximum number of rows that can be queried each day.
        /// </summary>
        [NameInMap("MaxResultCount")]
        [Validation(Required=false)]
        public long? MaxResultCount { get; set; }

        /// <summary>
        /// The DingTalk ID or mobile number of the user.
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// The roles that the user assumes. For more information about the valid values, see the Request parameters section in the [UpdateUser](https://help.aliyun.com/document_detail/465812.html) topic.
        /// </summary>
        [NameInMap("RoleNames")]
        [Validation(Required=false)]
        public string RoleNames { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > : To view the ID of the tenant, log on to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [Manage DMS tenants](https://help.aliyun.com/document_detail/181330.html).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The Alibaba Cloud unique ID (UID) of the user to update.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// The nickname of the user.
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
