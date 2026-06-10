// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UpdateMiniAppBindingRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
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
        /// <para>Configuration key</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("SettingKey")]
        [Validation(Required=false)]
        public string SettingKey { get; set; }

        /// <summary>
        /// <para>Configuration value</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("SettingValue")]
        [Validation(Required=false)]
        public string SettingValue { get; set; }

    }

}
