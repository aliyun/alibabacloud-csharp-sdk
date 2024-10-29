// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("AttributeValue")]
        [Validation(Required=false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>用户组名称。长度为1~128个字符，支持中文和大小写英文字母，可包含数字、半角句号（.）、下划线（_）和短划线（-）。</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_group_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-policy-54a7838a48bf****</para>
        /// </summary>
        [NameInMap("PAPolicyId")]
        [Validation(Required=false)]
        public string PAPolicyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
