// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetApiProductsAuthoritiesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The API products.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApiProductIds")]
        [Validation(Required=false)]
        public string ApiProductIdsShrink { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111385984</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>授权有效时间的截止时间，请设置格林尼治标准时间(GMT), 如果为空，即为授权永久有效。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-12T03:07:37Z</para>
        /// </summary>
        [NameInMap("AuthValidTime")]
        [Validation(Required=false)]
        public string AuthValidTime { get; set; }

        /// <summary>
        /// <para>The authorization description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
