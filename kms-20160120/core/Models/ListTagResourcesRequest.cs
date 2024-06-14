// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// 
        /// >  If the call does not return all result entries, the value of the NextToken parameter is returned. By default, 200 rows are returned. You can call this operation again and set the value of the parameter to the value of the parameter that is returned in the last call to implement paged query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the resource.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/601478.html) to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// A list of resource IDs for which you want to query tags. You can enter a maximum of 50 resource IDs.
        /// 
        /// Enter multiple resource IDs in the `["ResourceId. 1","ResourceId. 2",...]` format.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of resource whose tags you want to query. Valid value:
        /// 
        /// *   key
        /// *   secret
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// A list of tags that you want to query. Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. A tag consists of a key-value pair.
            /// 
            /// You can enter up to 20 tags. Enter multiple tags in the `[{"Key":"key1","Value":"value1"},{"Key":"key2","Value":"value2"},..]` format.
            /// 
            /// >  The key cannot start with aliyun or acs:.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. A tag consists of a key-value pair.
            /// 
            /// You can enter up to 20 tags. Enter multiple tags in the `[{"Key":"key1","Value":"value1"},{"Key":"key2","Value":"value2"},..]` format.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
