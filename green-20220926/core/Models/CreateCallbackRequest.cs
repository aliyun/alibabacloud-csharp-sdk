// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreateCallbackRequest : TeaModel {
        /// <summary>
        /// <para>Encryption algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHA256</para>
        /// </summary>
        [NameInMap("CryptType")]
        [Validation(Required=false)]
        public string CryptType { get; set; }

        /// <summary>
        /// <para>Plan name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>消息通知1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Review result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>Callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://console.aliyun.com">https://console.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
