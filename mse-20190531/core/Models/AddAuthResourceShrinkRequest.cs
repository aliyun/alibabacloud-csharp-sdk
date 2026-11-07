// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddAuthResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The authorization ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        /// <summary>
        /// <para>The list of authentication resource headers.</para>
        /// </summary>
        [NameInMap("AuthResourceHeaderList")]
        [Validation(Required=false)]
        public string AuthResourceHeaderListShrink { get; set; }

        /// <summary>
        /// <para>The domain name ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        /// <summary>
        /// <para>The unique gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-86575c0bc9f04ecfbacb92b8e392****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore case. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreCase")]
        [Validation(Required=false)]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// <para>The match type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EQUAL: Exact match.</description></item>
        /// <item><description>PRE: Prefix match.</description></item>
        /// <item><description>ERGULAR: Regular expression match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRE</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/abc</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
