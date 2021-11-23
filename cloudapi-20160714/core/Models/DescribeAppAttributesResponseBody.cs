// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppAttributesResponseBody : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public DescribeAppAttributesResponseBodyApps Apps { get; set; }
        public class DescribeAppAttributesResponseBodyApps : TeaModel {
            [NameInMap("AppAttribute")]
            [Validation(Required=false)]
            public List<DescribeAppAttributesResponseBodyAppsAppAttribute> AppAttribute { get; set; }
            public class DescribeAppAttributesResponseBodyAppsAppAttribute : TeaModel {
                public long? AppId { get; set; }
                public string AppName { get; set; }
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string ModifiedTime { get; set; }
                public DescribeAppAttributesResponseBodyAppsAppAttributeTags Tags { get; set; }
                public class DescribeAppAttributesResponseBodyAppsAppAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeAppAttributesResponseBodyAppsAppAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribeAppAttributesResponseBodyAppsAppAttributeTagsTagInfo : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
