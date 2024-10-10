// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class BatchAddFeishuUsersRequest : TeaModel {
        [NameInMap("FeishuUsers")]
        [Validation(Required=false)]
        public string FeishuUsers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAuthAdmin")]
        [Validation(Required=false)]
        public bool? IsAuthAdmin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;0d5fb19b-5555-41f0-99da-1248fc27ca51,0f868dd6_68dd_4d13_8422_c5dca3bd4b61&quot;</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
