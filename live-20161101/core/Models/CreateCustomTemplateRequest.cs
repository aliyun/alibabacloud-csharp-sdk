// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateCustomTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the template. The value is in the following JSON format: {height:xxx,scale:xxx,gop:xxx,bframes:xxx,cdesc:xxx}. All fields are required. If any field is left empty, the call fails.</para>
        /// <remarks>
        /// <para> For more information, see <b>Fields of the CustomTemplate parameter</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{height:1080,scale:[16:9],gop:60,bframes:30,cdesc:h264}</para>
        /// </summary>
        [NameInMap("CustomTemplate")]
        [Validation(Required=false)]
        public string CustomTemplate { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <remarks>
        /// <para>Record the template name. The template name is required if you want to use, query, or delete the template.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTemplate</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
