// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateSaseUserTagRequest : TeaModel {
        /// <summary>
        /// <para>The description of the user tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>These are the company\&quot;s employees</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the user tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>boss</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the user tag. You can obtain the tag ID from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListSaseUserTags~~">ListSaseUserTags</a>: Lists user tags.</description></item>
        /// <item><description><a href="~~CreateSaseUserTag~~">CreateSaseUserTag</a>: Creates a user tag.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
