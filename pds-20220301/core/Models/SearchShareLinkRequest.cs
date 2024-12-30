// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchShareLinkRequest : TeaModel {
        /// <summary>
        /// <para>The creators of shares. Set this parameter to a user ID. If you do not specify this parameter, Drive and Photo Service automatically queries shares based on your permissions. If you are a drive administrator or the super administrator, the shares created by all members are queried. If you are a team administrator, the shares created by all team members are queried. If you are a common user, only the shares created by yourself are queried.</para>
        /// <para>If you specify this parameter, this parameter must be set to the ID of the super administrator, a drive administrator, or a team administrator.</para>
        /// </summary>
        [NameInMap("creators")]
        [Validation(Required=false)]
        public List<string> Creators { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 100. Default value: 100.</para>
        /// <para>The number of returned results must be less than or equal to the specified number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned results. Default value: created_at. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>share_name: sorts the results by the name of the share.</description></item>
        /// <item><description>updated_at: sorts the results by the time when the share was modified.</description></item>
        /// <item><description>description: sorts the results by the description of the share.</description></item>
        /// <item><description>created_at: sorts the results by the time when the share was created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>created_at</para>
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the returned results. By default, order_direction is set to DESC if order_by is set to created_at or updated_at, and is set to ASC if order_by is set to other values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: sorts the results in ascending order.</description></item>
        /// <item><description>DESC: sorts the results in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The query condition that is used to search for share URLs. You can use the following fields to specify query conditions: created_at: queries a share URL based on the time when the share URL was created. updated_at: queries a share URL based on the time when the share URL was modified. share_name_for_fuzzy: queries a share URL based on the name of the share. A fuzzy match is supported. status: queries a share URL based on the status of the share. Valid values: enabled and disabled. A value of enabled indicates that the share is valid. A value of disabled indicates that the share is canceled. expired_time: queries a share URL based on the expiration time of the share. If the share never expires, set this field to 1970-01-01T00:00:00. Otherwise, set this field to 1970-01-02T00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>created_at&gt;=\&quot;2022-01-18T02:50:00\&quot; and created_at&lt;\&quot;2022-01-19T09:45:28\&quot; and share_name_for_fuzzy match \&quot;HD.mp4\&quot; and status in [\&quot;enabled\&quot;, \&quot;disabled\&quot;] and expired_time=\&quot;1970-01-01T00:00:00\&quot;</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("return_total_count")]
        [Validation(Required=false)]
        public bool? ReturnTotalCount { get; set; }

    }

}
