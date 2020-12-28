// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeImageGatewayConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Imagegw")]
        [Validation(Required=false)]
        public DescribeImageGatewayConfigResponseBodyImagegw Imagegw { get; set; }
        public class DescribeImageGatewayConfigResponseBodyImagegw : TeaModel {
            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<DescribeImageGatewayConfigResponseBodyImagegwLocations> Locations { get; set; }
            public class DescribeImageGatewayConfigResponseBodyImagegwLocations : TeaModel {
                public string RemoteType { get; set; }
                public string URL { get; set; }
                public string Location { get; set; }
                public string Authentication { get; set; }
            }
            [NameInMap("UpdateDateTime")]
            [Validation(Required=false)]
            public string UpdateDateTime { get; set; }
            [NameInMap("ImageExpirationTimeout")]
            [Validation(Required=false)]
            public string ImageExpirationTimeout { get; set; }
            [NameInMap("MongoDBURI")]
            [Validation(Required=false)]
            public string MongoDBURI { get; set; }
            [NameInMap("DefaultImageLocation")]
            [Validation(Required=false)]
            public string DefaultImageLocation { get; set; }
            [NameInMap("PullUpdateTimeout")]
            [Validation(Required=false)]
            public long? PullUpdateTimeout { get; set; }
        };

    }

}
