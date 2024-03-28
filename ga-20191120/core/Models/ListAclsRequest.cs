// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAclsRequest : TeaModel {
        /// <summary>
        /// The ID of the network ACL. You can specify up to 20 network ACL IDs in each request.
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public List<string> AclIds { get; set; }

        /// <summary>
        /// The name of the network ACL. You can specify up to 10 network ACL names in each request.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1** to **50**. Default value: **10**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If this is your first and only query, ignore this parameter.
        /// *   If a subsequent query is to be performed, set the parameter to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags of the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListAclsRequestTag> Tag { get; set; }
        public class ListAclsRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the network ACL. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the network ACL. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag values.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
