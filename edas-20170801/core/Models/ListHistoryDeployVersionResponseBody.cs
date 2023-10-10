// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListHistoryDeployVersionResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information about historical deployment packages.
        /// </summary>
        [NameInMap("PackageVersionList")]
        [Validation(Required=false)]
        public ListHistoryDeployVersionResponseBodyPackageVersionList PackageVersionList { get; set; }
        public class ListHistoryDeployVersionResponseBodyPackageVersionList : TeaModel {
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public List<ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion> PackageVersion { get; set; }
            public class ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The time when the deployment package was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The description of the deployment package.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The unique ID of the deployment package.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The version of the application that was released by using the deployment package. This version can be used to call the RollbackApplication operation.
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// The URL of the deployment package.
                /// </summary>
                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

                /// <summary>
                /// The deployment mode of the application. Valid values:
                /// 
                /// *   url: The application is deployed by using a JAR or WAR package.
                /// *   image: The application is deployed by using an image.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The time when the deployment package was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The URL of the deployment package.
                /// </summary>
                [NameInMap("WarUrl")]
                [Validation(Required=false)]
                public string WarUrl { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
