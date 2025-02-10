// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCacheTagResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the matching is not case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: The matching is not case-sensitive.</description></item>
        /// <item><description>off: The matching is case-sensitive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CaseInsensitive")]
        [Validation(Required=false)]
        public string CaseInsensitive { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version number of the website.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>The name of the custom cache tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
