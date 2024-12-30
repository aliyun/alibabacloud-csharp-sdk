// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the group of which you want to query members.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e5***2c2</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 100. Default value: 100.</para>
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
        /// <para>The member type. If you do not specify this parameter, both types of members are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user</description></item>
        /// <item><description>group</description></item>
        /// </list>
        /// <para>Note: A group can be a member of only one group. It cannot be a member of multiple groups. A user can be a member of multiple groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("member_type")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

    }

}
