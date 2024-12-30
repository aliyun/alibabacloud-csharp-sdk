// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListAssignmentRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 100.</para>
        /// <para>The number of returned results must be less than or equal to the specified number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The ID of the managed resource, such as a group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105***b82</para>
        /// </summary>
        [NameInMap("manage_resource_id")]
        [Validation(Required=false)]
        public string ManageResourceId { get; set; }

        /// <summary>
        /// <para>The type of the managed resource. Set the value to RT_Group, which specifies that the administrators of a group are queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RT_Group</para>
        /// </summary>
        [NameInMap("manage_resource_type")]
        [Validation(Required=false)]
        public string ManageResourceType { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker. By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

    }

}
