// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeImageGatewayConfigResponseBody : TeaModel {
        [NameInMap("Imagegw")]
        [Validation(Required=false)]
        public DescribeImageGatewayConfigResponseBodyImagegw Imagegw { get; set; }
        public class DescribeImageGatewayConfigResponseBodyImagegw : TeaModel {
            [NameInMap("DefaultImageLocation")]
            [Validation(Required=false)]
            public string DefaultImageLocation { get; set; }

            [NameInMap("ImageExpirationTimeout")]
            [Validation(Required=false)]
            public string ImageExpirationTimeout { get; set; }

            [NameInMap("Locations")]
            [Validation(Required=false)]
            public DescribeImageGatewayConfigResponseBodyImagegwLocations Locations { get; set; }
            public class DescribeImageGatewayConfigResponseBodyImagegwLocations : TeaModel {
                [NameInMap("LocationInfo")]
                [Validation(Required=false)]
                public List<DescribeImageGatewayConfigResponseBodyImagegwLocationsLocationInfo> LocationInfo { get; set; }
                public class DescribeImageGatewayConfigResponseBodyImagegwLocationsLocationInfo : TeaModel {
                    [NameInMap("Authentication")]
                    [Validation(Required=false)]
                    public string Authentication { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("RemoteType")]
                    [Validation(Required=false)]
                    public string RemoteType { get; set; }

                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

            }

            [NameInMap("MongoDBURI")]
            [Validation(Required=false)]
            public string MongoDBURI { get; set; }

            [NameInMap("PullUpdateTimeout")]
            [Validation(Required=false)]
            public long? PullUpdateTimeout { get; set; }

            [NameInMap("UpdateDateTime")]
            [Validation(Required=false)]
            public string UpdateDateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
