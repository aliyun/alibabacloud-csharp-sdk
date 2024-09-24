// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOrUpdateAssetGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the server group for which you want to add to or remove servers.</para>
        /// <remarks>
        /// <para> To modify the mapping between an asset and an asset group, you must provide the ID of the asset group. You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> to query the IDs of asset groups. If you do not configure this parameter when you call this operation, an asset group is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>55426</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The name of the server group that you want to create or the server group for which you want to add or remove a server.</para>
        /// <remarks>
        /// <para> To modify the mapping between a server and a server group, you must provide the name of the server group. You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the names of server groups. If you do not configure GroupID when you call this operation, a server group is created. In this case, you must configure GroupName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The UUID of the server in the server group that you want to create or the server group for which you want to add or remove servers. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aq12-<em><b>,s23</b></em></para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
