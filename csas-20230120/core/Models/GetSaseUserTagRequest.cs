// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetSaseUserTagRequest : TeaModel {
        /// <summary>
        /// <para>The user tag ID. You can obtain this value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListSaseUserTags~~">ListSaseUserTags</a>: Lists user tags.</description></item>
        /// <item><description><a href="~~CreateSaseUserTag~~">CreateSaseUserTag</a>: Creates a user tag.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>su-tag-1ae52f66039fa0d4****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
