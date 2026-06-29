// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>UID of the RAM user (sub-account) under the current Alibaba Cloud account (primary account). For information about how to obtain the UID, see <a href="https://help.aliyun.com/document_detail/2330970.html">GetUser</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>166***980757310</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public string AccountNo { get; set; }

        /// <summary>
        /// <para>Account type. Only ALIYUN is currently supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>Role. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>OPERATOR: Annotator.  </description></item>
        /// <item><description>ADMIN: Administrator.  </description></item>
        /// <item><description>LEADER: Annotation team leader.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADMIN</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>Username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
