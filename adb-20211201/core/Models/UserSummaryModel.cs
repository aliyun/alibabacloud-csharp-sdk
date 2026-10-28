// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UserSummaryModel : TeaModel {
        /// <summary>
        /// <para>The list of access tokens for the user.</para>
        /// </summary>
        [NameInMap("AccessTokens")]
        [Validation(Required=false)]
        public List<AccessTokenModel> AccessTokens { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The ID of the associated Alibaba Cloud RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1444832459****</para>
        /// </summary>
        [NameInMap("RamUser")]
        [Validation(Required=false)]
        public string RamUser { get; set; }

        /// <summary>
        /// <para>The user status.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
