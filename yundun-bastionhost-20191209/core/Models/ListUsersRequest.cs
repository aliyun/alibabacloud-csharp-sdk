// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListUsersRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("UserState")]
        [Validation(Required=false)]
        public string UserState { get; set; }

        [NameInMap("SourceUserId")]
        [Validation(Required=false)]
        public string SourceUserId { get; set; }

        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
