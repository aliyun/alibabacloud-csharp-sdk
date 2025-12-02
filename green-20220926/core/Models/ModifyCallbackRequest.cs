// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ModifyCallbackRequest : TeaModel {
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
        /// <para>Primary key ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>回调通知</para>
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
        /// <para>Result scope.</para>
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
        /// <para><a href="https://www.aliyuncs.com">https://www.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
