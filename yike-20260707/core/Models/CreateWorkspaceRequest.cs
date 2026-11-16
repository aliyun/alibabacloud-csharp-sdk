// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the studio. The name can be up to 50 characters in length and cannot contain single quotation marks, semicolons, less than signs, greater than signs, equal signs, vertical lines, or parentheses.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Video production studio</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The maximum number of users allowed in the studio team. Valid values: 2 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UserCountLimit")]
        [Validation(Required=false)]
        public long? UserCountLimit { get; set; }

    }

}
