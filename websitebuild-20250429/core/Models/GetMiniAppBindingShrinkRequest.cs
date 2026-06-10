// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetMiniAppBindingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Site ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Channel</para>
        /// 
        /// <b>Example:</b>
        /// <para>WECHAT</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>List of extension information keys</para>
        /// 
        /// <b>Example:</b>
        /// <para>SERVER_DOMAIN</para>
        /// </summary>
        [NameInMap("SettingKeys")]
        [Validation(Required=false)]
        public string SettingKeysShrink { get; set; }

    }

}
