// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateModelTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;defaults&quot;: {
        ///         &quot;model&quot;: {
        ///             &quot;primary&quot;: &quot;bailian/qwen3.5-plus&quot;
        ///         }
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model-template-001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
