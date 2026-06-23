// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCustomAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The custom attribute ID. The ID must match the regular expression <c>^custom-attribute:[A-Za-z][A-Za-z0-9_]{0,98}$</c>. The part after \&quot;custom-attribute:\&quot; must be less than 100 characters long.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-attribute:biz_owner</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
