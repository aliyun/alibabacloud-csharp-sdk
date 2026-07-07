// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LeavePictureList : TeaModel {
        /// <summary>
        /// <para>Description&gt;Notice: If the after-sales order rendering API returns that a message description is required, this field is mandatory.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>外观破损了。</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>Image of the after-sales Credential&gt;Notice: If the after-sales order rendering API returns that an after-sales image is required, this field is mandatory.</notice></para>
        /// </summary>
        [NameInMap("picture")]
        [Validation(Required=false)]
        public string Picture { get; set; }

    }

}
