// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeAppDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAppDetailResponseBodyResult Result { get; set; }
        public class DescribeAppDetailResponseBodyResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }
            [NameInMap("AppStateType")]
            [Validation(Required=false)]
            public string AppStateType { get; set; }
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }
            [NameInMap("BizTitle")]
            [Validation(Required=false)]
            public string BizTitle { get; set; }
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }
            [NameInMap("MiddleWareInfoList")]
            [Validation(Required=false)]
            public List<DescribeAppDetailResponseBodyResultMiddleWareInfoList> MiddleWareInfoList { get; set; }
            public class DescribeAppDetailResponseBodyResultMiddleWareInfoList : TeaModel {
                public long? AppId { get; set; }
                public int? Code { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("OperatingSystem")]
            [Validation(Required=false)]
            public string OperatingSystem { get; set; }
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("UserRoles")]
            [Validation(Required=false)]
            public List<DescribeAppDetailResponseBodyResultUserRoles> UserRoles { get; set; }
            public class DescribeAppDetailResponseBodyResultUserRoles : TeaModel {
                public string RealName { get; set; }
                public string RoleName { get; set; }
                public string UserId { get; set; }
                public string UserType { get; set; }
            }
        };

    }

}
