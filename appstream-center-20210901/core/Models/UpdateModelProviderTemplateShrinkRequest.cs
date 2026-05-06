// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateModelProviderTemplateShrinkRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string ConfigShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWuyingProxy")]
        [Validation(Required=false)]
        public bool? EnableWuyingProxy { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mpt-xxxx</para>
        /// </summary>
        [NameInMap("ProviderTemplateId")]
        [Validation(Required=false)]
        public string ProviderTemplateId { get; set; }

    }

}
