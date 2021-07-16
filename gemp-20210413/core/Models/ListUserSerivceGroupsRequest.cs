// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListUserSerivceGroupsRequest : TeaModel {
        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
