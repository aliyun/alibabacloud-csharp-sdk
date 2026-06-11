// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListWorkspaceUserRolesByUserIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Quick BI user. This is not your Alibaba Cloud account ID. You can call the <a href="https://next.api.aliyun.com/api/quickbi-public/2022-01-01/QueryUserInfoByAccount?spm=api-workbench.api_explorer.0.0.672f50daGq9ooV%5C&params=%7B%7D%5C&tab=DOC%5C&sdkStyle=old%5C&RegionId=cn-hangzhou">QueryUserInfoByAccount</a> operation to obtain the user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afas-********asfasg</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
