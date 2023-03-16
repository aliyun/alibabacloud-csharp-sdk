// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeImageGatewayConfigResponseBody : TeaModel {
        /// <summary>
        /// The information about the image gateway configuration file.
        /// </summary>
        [NameInMap("Imagegw")]
        [Validation(Required=false)]
        public DescribeImageGatewayConfigResponseBodyImagegw Imagegw { get; set; }
        public class DescribeImageGatewayConfigResponseBodyImagegw : TeaModel {
            /// <summary>
            /// The default address of the image repository.
            /// </summary>
            [NameInMap("DefaultImageLocation")]
            [Validation(Required=false)]
            public string DefaultImageLocation { get; set; }

            /// <summary>
            /// The time when the image expires.
            /// </summary>
            [NameInMap("ImageExpirationTimeout")]
            [Validation(Required=false)]
            public string ImageExpirationTimeout { get; set; }

            /// <summary>
            /// An array of the image repository addresses.
            /// </summary>
            [NameInMap("Locations")]
            [Validation(Required=false)]
            public DescribeImageGatewayConfigResponseBodyImagegwLocations Locations { get; set; }
            public class DescribeImageGatewayConfigResponseBodyImagegwLocations : TeaModel {
                [NameInMap("LocationInfo")]
                [Validation(Required=false)]
                public List<DescribeImageGatewayConfigResponseBodyImagegwLocationsLocationInfo> LocationInfo { get; set; }
                public class DescribeImageGatewayConfigResponseBodyImagegwLocationsLocationInfo : TeaModel {
                    /// <summary>
                    /// The authentication method of the image repository. Valid values:
                    /// 
                    /// *   http
                    /// *   https
                    /// </summary>
                    [NameInMap("Authentication")]
                    [Validation(Required=false)]
                    public string Authentication { get; set; }

                    /// <summary>
                    /// The source address of the image repository.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The type of the image repository.
                    /// </summary>
                    [NameInMap("RemoteType")]
                    [Validation(Required=false)]
                    public string RemoteType { get; set; }

                    /// <summary>
                    /// The URL of the image repository.
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

            }

            /// <summary>
            /// The information about the image gateway database.
            /// </summary>
            [NameInMap("MongoDBURI")]
            [Validation(Required=false)]
            public string MongoDBURI { get; set; }

            /// <summary>
            /// The timeout period for pulling images.
            /// </summary>
            [NameInMap("PullUpdateTimeout")]
            [Validation(Required=false)]
            public long? PullUpdateTimeout { get; set; }

            /// <summary>
            /// The time when the file was updated.
            /// </summary>
            [NameInMap("UpdateDateTime")]
            [Validation(Required=false)]
            public string UpdateDateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
