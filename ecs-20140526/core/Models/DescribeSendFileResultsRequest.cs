// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSendFileResultsRequest : TeaModel {
        /// <summary>
        /// The ID of the instance for which you want to query file sending records.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The overall sending status of the file. The overall sending status of the file varies based on the sending status of the file on all destination instances. Valid values:
        /// 
        /// *   Pending: The file is being verified or sent. If the sending state of the file on at least one instance is Pending, the overall sending state of the file is Pending.
        /// *   Running: The file is being sent to the instances. If the sending state of the file on at least one instance is Running, the overall sending state of the file is Running.
        /// *   Success: The file is sent. If the sending state of the file on all instances is Success, the overall sending state of the file is Success.
        /// *   Failed: The file fails to be sent. If the sending state of the file on all instances is Failed, the overall sending state of the file is Failed.
        /// *   PartialFailed: The file sending task succeeds on some instances and fails on other instances. If the sending state of the file is Success on some instances and is Failed on other instances, the overall sending state of the file is PartialFailed.
        /// </summary>
        [NameInMap("InvocationStatus")]
        [Validation(Required=false)]
        public string InvocationStatus { get; set; }

        /// <summary>
        /// The ID of the file sending task.
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// The maximum number of entries per page.
        /// 
        /// Valid values: 1 to 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The name of the file whose sending records you want to query.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID of the ECS instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. After you set this parameter, file sending results in the specified resource group are queried.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags of the file sending task.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSendFileResultsRequestTag> Tag { get; set; }
        public class DescribeSendFileResultsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the file sending task. Valid values of N: 1 to 20. The tag key cannot be an empty string.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all the tags added can be displayed in the response. To query more than 1,000 resources that have specified tags, call the [ListTagResources](https://help.aliyun.com/document_detail/110425.html) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the file sending task. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
