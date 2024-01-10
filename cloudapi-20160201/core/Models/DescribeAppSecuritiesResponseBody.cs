// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribeAppSecuritiesResponseBody : TeaModel {
        [NameInMap("AppSecuritys")]
        [Validation(Required=false)]
        public DescribeAppSecuritiesResponseBodyAppSecuritys AppSecuritys { get; set; }
        public class DescribeAppSecuritiesResponseBodyAppSecuritys : TeaModel {
            [NameInMap("AppSecurity")]
            [Validation(Required=false)]
            public List<DescribeAppSecuritiesResponseBodyAppSecuritysAppSecurity> AppSecurity { get; set; }
            public class DescribeAppSecuritiesResponseBodyAppSecuritysAppSecurity : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
