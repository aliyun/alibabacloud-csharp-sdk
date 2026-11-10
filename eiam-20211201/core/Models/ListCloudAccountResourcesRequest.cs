// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012xxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>Filters resources by entity type. Valid values: ram_policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram_policy</para>
        /// </summary>
        [NameInMap("CloudAccountResourceEntityType")]
        [Validation(Required=false)]
        public string CloudAccountResourceEntityType { get; set; }

        /// <summary>
        /// <para>Performs a fuzzy match on the resource name, which is equivalent to LIKE \&quot;%value%\&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sso</para>
        /// </summary>
        [NameInMap("CloudAccountResourceNameContains")]
        [Validation(Required=false)]
        public string CloudAccountResourceNameContains { get; set; }

        /// <summary>
        /// <para>Matches resources by resource name prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eiam-</para>
        /// </summary>
        [NameInMap("CloudAccountResourceNamePrefix")]
        [Validation(Required=false)]
        public string CloudAccountResourceNamePrefix { get; set; }

        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page for paging in a paged query. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. The value is the NextToken parameter value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
