// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class MemberApiKeyDTO : TeaModel {
        /// <summary>
        /// <para>The parent department information.</para>
        /// </summary>
        [NameInMap("client")]
        [Validation(Required=false)]
        public ClientDTO Client { get; set; }

        /// <summary>
        /// <para>The ID of the parent department. Member keys are mapped to their parent departments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>438</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The deletion tag. A value of 0 indicates that the key is enabled, and a non-zero value indicates that the key is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("deleteTag")]
        [Validation(Required=false)]
        public int? DeleteTag { get; set; }

        /// <summary>
        /// <para>The expiration time. A null value indicates that the key never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12-31T00:00:00Z</para>
        /// </summary>
        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public string ExpireAt { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-03T18:41:40+08:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-03T18:41:40+08:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The API key ID. This ID can be used to query the bound group by API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>502</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The full key. This field is not returned in the member list and is always empty.</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The masked preview of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-us****9876</para>
        /// </summary>
        [NameInMap("keyPreview")]
        [Validation(Required=false)]
        public string KeyPreview { get; set; }

        /// <summary>
        /// <para>The ID of the department member to whom the key belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>304</para>
        /// </summary>
        [NameInMap("memberUserId")]
        [Validation(Required=false)]
        public long? MemberUserId { get; set; }

        /// <summary>
        /// <para>The member name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("memberUserName")]
        [Validation(Required=false)]
        public string MemberUserName { get; set; }

        /// <summary>
        /// <para>The API key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San\&quot;s key</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status. Valid values: active: Enabled. disabled: Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
