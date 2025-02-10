// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCacheTagRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CaseInsensitive")]
        [Validation(Required=false)]
        public string CaseInsensitive { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407498413****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
