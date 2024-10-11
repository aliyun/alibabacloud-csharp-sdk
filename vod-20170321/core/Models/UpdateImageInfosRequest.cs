// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateImageInfosRequest : TeaModel {
        /// <summary>
        /// <para>The new information about the one or more images. You can modify the information about up to 20 images at a time. For more information about the parameter structure, see the <b>UpdateContent</b> section.</para>
        /// <remarks>
        /// <para> The values of the nested parameters Title, Description, and Tags under the UpdateContent parameter cannot contain emoticons.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ImageId&quot;:&quot;ff8fe57e3461416c6a267a4e09****&quot;,&quot;Title&quot;:&quot;test title&quot;,&quot;Description&quot;:&quot;test description&quot;,&quot;Tags&quot;:&quot;tag1,tag2&quot;}]</para>
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
