// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddUserToDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the shared cloud computer to which you want to add authorized users.</para>
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
        /// <para>The list of users to authorize.</para>
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
