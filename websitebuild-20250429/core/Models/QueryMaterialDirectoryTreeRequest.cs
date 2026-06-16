// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class QueryMaterialDirectoryTreeRequest : TeaModel {
        /// <summary>
        /// <para>The application instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide shared folders.</para>
        /// </summary>
        [NameInMap("HiddenPublic")]
        [Validation(Required=false)]
        public bool? HiddenPublic { get; set; }

        /// <summary>
        /// <para>Specifies whether to request the first-level root folder.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Root")]
        [Validation(Required=false)]
        public bool? Root { get; set; }

    }

}
