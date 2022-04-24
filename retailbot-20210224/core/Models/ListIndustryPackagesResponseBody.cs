// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListIndustryPackagesResponseBody : TeaModel {
        /// <summary>
        /// 返回code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PackagePage")]
        [Validation(Required=false)]
        public ListIndustryPackagesResponseBodyPackagePage PackagePage { get; set; }
        public class ListIndustryPackagesResponseBodyPackagePage : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public int? NextToken { get; set; }
            [NameInMap("Packages")]
            [Validation(Required=false)]
            public List<ListIndustryPackagesResponseBodyPackagePagePackages> Packages { get; set; }
            public class ListIndustryPackagesResponseBodyPackagePagePackages : TeaModel {
                public string CreateTime { get; set; }
                public string CreateUserId { get; set; }
                public string ModifyTime { get; set; }
                public string ModifyUserId { get; set; }
                public string PackageCode { get; set; }
                public string PackageDescription { get; set; }
                public string PackageName { get; set; }
                public string PackageType { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功标示
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
