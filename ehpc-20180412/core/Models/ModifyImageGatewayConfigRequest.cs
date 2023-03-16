// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyImageGatewayConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The password that is used to log on to the database instance.
        /// </summary>
        [NameInMap("DBPassword")]
        [Validation(Required=false)]
        public string DBPassword { get; set; }

        /// <summary>
        /// The URI of the database.
        /// </summary>
        [NameInMap("DBServerInfo")]
        [Validation(Required=false)]
        public string DBServerInfo { get; set; }

        /// <summary>
        /// The type of the database. Set the value to mongodb.
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The username of the account that is used to log on to the database.
        /// </summary>
        [NameInMap("DBUsername")]
        [Validation(Required=false)]
        public string DBUsername { get; set; }

        /// <summary>
        /// The default repository service. Set the value to registry-1.docker.io.
        /// </summary>
        [NameInMap("DefaultRepoLocation")]
        [Validation(Required=false)]
        public string DefaultRepoLocation { get; set; }

        /// <summary>
        /// The timeout period for deleting images.
        /// </summary>
        [NameInMap("ImageExpirationTimeout")]
        [Validation(Required=false)]
        public string ImageExpirationTimeout { get; set; }

        /// <summary>
        /// The timeout period for pulling images.
        /// </summary>
        [NameInMap("PullUpdateTimeout")]
        [Validation(Required=false)]
        public int? PullUpdateTimeout { get; set; }

        /// <summary>
        /// The information about the repository.
        /// </summary>
        [NameInMap("Repo")]
        [Validation(Required=false)]
        public List<ModifyImageGatewayConfigRequestRepo> Repo { get; set; }
        public class ModifyImageGatewayConfigRequestRepo : TeaModel {
            /// <summary>
            /// The authentication method of the repository. Valid values:
            /// 
            /// *   http
            /// *   https
            /// 
            /// Default value: http.
            /// </summary>
            [NameInMap("Auth")]
            [Validation(Required=false)]
            public string Auth { get; set; }

            /// <summary>
            /// The address of the repository N.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The URL of the repository. The URL is required to add a repository address.
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

    }

}
