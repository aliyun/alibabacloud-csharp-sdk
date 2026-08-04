// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeletePrivateAccessTagRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the internal access tag. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessTags~~">ListPrivateAccessTags</a>: Lists internal access tags.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessTag~~">CreatePrivateAccessTag</a>: Creates an internal access tag.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
