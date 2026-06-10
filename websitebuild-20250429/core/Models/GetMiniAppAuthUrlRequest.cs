// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetMiniAppAuthUrlRequest : TeaModel {
        /// <summary>
        /// <para>Site ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Channel information</para>
        /// 
        /// <b>Example:</b>
        /// <para>WECHAT</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>Hyperlink URL</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("RedirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

    }

}
