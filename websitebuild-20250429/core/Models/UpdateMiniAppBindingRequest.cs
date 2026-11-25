// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UpdateMiniAppBindingRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WECHAT</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The configuration key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SERVER_DOMAIN</para>
        /// </summary>
        [NameInMap("SettingKey")]
        [Validation(Required=false)]
        public string SettingKey { get; set; }

        /// <summary>
        /// <para>The configuration value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;requestDomains&quot;:[{&quot;domain&quot;:&quot;<a href="https://api.example.com%22%7D%5D,%22wsRequestDomains%22:%5B%5D,%22uploadDomains%22:%5B%5D,%22downloadDomains%22:%5B%5D,%22udpDomains%22:%5B%5D,%22tcpDomains%22:%5B%5D%7D">https://api.example.com&quot;}],&quot;wsRequestDomains&quot;:[],&quot;uploadDomains&quot;:[],&quot;downloadDomains&quot;:[],&quot;udpDomains&quot;:[],&quot;tcpDomains&quot;:[]}</a></para>
        /// </summary>
        [NameInMap("SettingValue")]
        [Validation(Required=false)]
        public string SettingValue { get; set; }

    }

}
