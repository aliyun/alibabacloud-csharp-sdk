// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OrgInitResultDTO : TeaModel {
        /// <summary>
        /// <para>The returned plaintext API key, which is visible only once during initialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The customer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The customer unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>st-xxxx</para>
        /// </summary>
        [NameInMap("clientUuid")]
        [Validation(Required=false)]
        public string ClientUuid { get; set; }

        /// <summary>
        /// <para>Indicates whether it is newly created. A value of false indicates that it already exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isNew")]
        [Validation(Required=false)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// <para>The enterprise ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
