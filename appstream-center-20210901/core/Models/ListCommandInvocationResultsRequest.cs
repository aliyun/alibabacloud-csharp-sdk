// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListCommandInvocationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group. Queries the command execution results under this delivery group. This parameter must be specified when AppInstanceGroupIds is not specified. If both are specified, AppInstanceGroupIds takes precedence and this parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-0bxls9m9arax6****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The list of delivery group IDs. A maximum of 200 IDs can be specified, and all delivery groups must be in the same region. When specified, it takes precedence over AppInstanceGroupId and queries the command execution results of all persistent sessions under these delivery groups. The list cannot contain null values.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIds { get; set; }

        /// <summary>
        /// <para>The list of persistent session IDs. A maximum of 100 IDs can be specified. It is used to query only the command execution results of the specified persistent sessions. When AppInstanceGroupIds is specified, only persistent sessions belonging to these delivery groups are retained. If no matching persistent sessions are found, an empty list is returned.</para>
        /// </summary>
        [NameInMap("AppInstancePersistentIds")]
        [Validation(Required=false)]
        public List<string> AppInstancePersistentIds { get; set; }

        /// <summary>
        /// <para>The command execution ID, which is the InvocationId returned when you call RunAppInstanceCommand to deliver a command.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0bxls9m9ara****</para>
        /// </summary>
        [NameInMap("InvocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect in the current version and does not affect the query results if passed. Use PageNumber and PageSize for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect in the current version and does not affect the query results if passed. Use PageNumber and PageSize for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kDw2Ml****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the query results to display. It is used together with PageSize for paging in a paged query. If not specified, the default value is 0, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of query results per page. Default value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. Currently, only WuyingServer is supported. If you specify other values, a parameter error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WuyingServer</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
