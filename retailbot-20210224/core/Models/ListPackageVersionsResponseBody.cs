// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListPackageVersionsResponseBody : TeaModel {
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

        /// <summary>
        /// 包集合
        /// </summary>
        [NameInMap("Packages")]
        [Validation(Required=false)]
        public List<ListPackageVersionsResponseBodyPackages> Packages { get; set; }
        public class ListPackageVersionsResponseBodyPackages : TeaModel {
            /// <summary>
            /// 包code
            /// </summary>
            [NameInMap("PackageCode")]
            [Validation(Required=false)]
            public string PackageCode { get; set; }

            /// <summary>
            /// 包详细信息
            /// </summary>
            [NameInMap("PackageDetails")]
            [Validation(Required=false)]
            public List<ListPackageVersionsResponseBodyPackagesPackageDetails> PackageDetails { get; set; }
            public class ListPackageVersionsResponseBodyPackagesPackageDetails : TeaModel {
                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 创建人id
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// 修改人id
                /// </summary>
                [NameInMap("ModifyUserId")]
                [Validation(Required=false)]
                public string ModifyUserId { get; set; }

                /// <summary>
                /// 包详细描述
                /// </summary>
                [NameInMap("PackageDetailDescription")]
                [Validation(Required=false)]
                public string PackageDetailDescription { get; set; }

                /// <summary>
                /// 包版本
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// 发布时间
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

            }

            /// <summary>
            /// 包名
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

        }

        /// <summary>
        /// Id of the request
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
