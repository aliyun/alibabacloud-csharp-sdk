// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class UpdateAppRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("BizTitle")]
        [Validation(Required=false)]
        public string BizTitle { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("MiddleWareIdList")]
        [Validation(Required=false)]
        public List<int?> MiddleWareIdList { get; set; }

        [NameInMap("OperatingSystem")]
        [Validation(Required=false)]
        public string OperatingSystem { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("UserRoles")]
        [Validation(Required=false)]
        public List<UpdateAppRequestUserRoles> UserRoles { get; set; }
        public class UpdateAppRequestUserRoles : TeaModel {
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
