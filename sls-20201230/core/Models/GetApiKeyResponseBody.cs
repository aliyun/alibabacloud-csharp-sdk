// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Logstores that allow writes.</para>
        /// </summary>
        [NameInMap("allowedStores")]
        [Validation(Required=false)]
        public List<string> AllowedStores { get; set; }

        /// <summary>
        /// <para>The API key in plaintext.</para>
        /// 
        /// <b>Example:</b>
        /// <apiKey-plaintext>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The API key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-apikey-001</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788420000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The status of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled / Disabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788420000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public int? UpdateTime { get; set; }

    }

}
