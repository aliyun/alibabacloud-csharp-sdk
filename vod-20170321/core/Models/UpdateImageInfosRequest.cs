// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateImageInfosRequest : TeaModel {
        /// <summary>
        /// <para>The update content. You can modify the information of up to 20 images at a time. For the parameter structure, refer to the <b>UpdateContent</b> table below.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The Title, Description, and Tags fields cannot contain emojis.</description></item>
        /// <item><description>If a parameter is passed, the corresponding field is updated. Otherwise, the corresponding field is not overwritten or updated.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ImageId&quot;:&quot;ff8fe57e3461416c6a267a4e09****&quot;,&quot;Title&quot;:&quot;Title&quot;,&quot;Description&quot;:&quot;Description&quot;,&quot;Tags&quot;:&quot;Tag1,Tag2&quot;}]</para>
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
