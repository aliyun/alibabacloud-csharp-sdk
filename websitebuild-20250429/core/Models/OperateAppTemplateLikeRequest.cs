// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class OperateAppTemplateLikeRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether the item is collected</para>
        /// </summary>
        [NameInMap("Liked")]
        [Validation(Required=false)]
        public bool? Liked { get; set; }

        /// <summary>
        /// <para>Template ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>K191WHV12URYQN06</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
