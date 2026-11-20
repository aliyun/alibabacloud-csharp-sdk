// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the dynamic parameter was created. The time is displayed in UTC and follows the RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-15T10:30:00Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The name of the dynamic parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_gateway.route_policy</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The time when the dynamic parameter was updated. The time is displayed in UTC and follows the RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-15T11:00:00Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The value of the dynamic parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model&quot;: &quot;gpt-4-turbo&quot;}</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
