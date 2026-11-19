// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CheckOrganizationMemberRequest : TeaModel {
        /// <summary>
        /// <para>The user ID in Quick BI. This is not your Alibaba Cloud account ID. You can call the <a href="https://next.api.aliyun.com/api/quickbi-public/2022-01-01/QueryUserInfoByAccount?spm=api-workbench.api_explorer.0.0.672f50daGq9ooV&params=%7B%7D&tab=DOC&sdkStyle=old&RegionId=cn-hangzhou">QueryUserInfoByAccount</a> operation to obtain the user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adfssd-sdf****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
