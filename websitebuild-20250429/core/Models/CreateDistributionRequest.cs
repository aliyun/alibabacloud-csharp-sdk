// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateDistributionRequest : TeaModel {
        /// <summary>
        /// <para>The article ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28733</para>
        /// </summary>
        [NameInMap("ArticleId")]
        [Validation(Required=false)]
        public string ArticleId { get; set; }

        /// <summary>
        /// <para>The list of selected channels.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

    }

}
