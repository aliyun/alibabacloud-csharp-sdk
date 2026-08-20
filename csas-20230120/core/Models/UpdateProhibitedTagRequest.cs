// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateProhibitedTagRequest : TeaModel {
        /// <summary>
        /// <para>The description of the prohibited software tag. The description can contain letters, digits, Chinese characters, spaces, periods (.), underscores (_), and hyphens (-), and cannot exceed 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the prohibited software tag. The name must be 1 to 128 characters in length and can contain letters, digits, Chinese characters, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Edge</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the custom prohibited software tag. Only custom tags under the current Alibaba Cloud account can be modified. Built-in system tags cannot be modified. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListProhibitedTags~~">ListProhibitedTags</a>: Lists prohibited software tags.</description></item>
        /// <item><description><a href="~~CreateProhibitedTag~~">CreateProhibitedTag</a>: Creates a custom prohibited software tag.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag-996078937c00****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
