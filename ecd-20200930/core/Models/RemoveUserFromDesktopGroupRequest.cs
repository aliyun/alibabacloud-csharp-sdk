// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RemoveUserFromDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the shared cloud computer from which to remove authorized users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The list of shared cloud computer IDs.</para>
        /// </summary>
        [NameInMap("DesktopGroupIds")]
        [Validation(Required=false)]
        public List<string> DesktopGroupIds { get; set; }

        /// <summary>
        /// <para>The list of authorized users to remove.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The organization ID of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-aliyun-wy-org-id</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The convenience user group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ug-3f6c8a2b****</para>
        /// </summary>
        [NameInMap("SimpleUserGroupId")]
        [Validation(Required=false)]
        public string SimpleUserGroupId { get; set; }

        /// <summary>
        /// <para>The user group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Group</para>
        /// </summary>
        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

        /// <summary>
        /// <para>The organizational unit (OU) path of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("UserOuPath")]
        [Validation(Required=false)]
        public string UserOuPath { get; set; }

    }

}
