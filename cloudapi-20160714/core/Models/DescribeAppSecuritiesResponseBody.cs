// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppSecuritiesResponseBody : TeaModel {
        /// <summary>
        /// The associated security policy information.
        /// </summary>
        [NameInMap("AppSecuritys")]
        [Validation(Required=false)]
        public DescribeAppSecuritiesResponseBodyAppSecuritys AppSecuritys { get; set; }
        public class DescribeAppSecuritiesResponseBodyAppSecuritys : TeaModel {
            [NameInMap("AppSecurity")]
            [Validation(Required=false)]
            public List<DescribeAppSecuritiesResponseBodyAppSecuritysAppSecurity> AppSecurity { get; set; }
            public class DescribeAppSecuritiesResponseBodyAppSecuritysAppSecurity : TeaModel {
                /// <summary>
                /// The application AppCode.
                /// </summary>
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                /// <summary>
                /// The application AppKey.
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// The application AppSecret.
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// The time when the AppKey was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The time when the AppSecret was last modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
