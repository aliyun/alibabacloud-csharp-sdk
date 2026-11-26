// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeFaq : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>可按约定范围提供实施服务。</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>是否提供实施服务？</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

    }

}
