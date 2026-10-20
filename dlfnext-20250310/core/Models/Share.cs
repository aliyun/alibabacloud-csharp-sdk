// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Share : TeaModel {
        /// <summary>
        /// <para>The comment information of the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time of the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>Specifies whether write operations are allowed on shared resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableWrite")]
        [Validation(Required=false)]
        public bool? EnableWrite { get; set; }

        /// <summary>
        /// <para>The owner of the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The account ID of the provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("providerTenantId")]
        [Validation(Required=false)]
        public long? ProviderTenantId { get; set; }

        /// <summary>
        /// <para>The share ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("shareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The share name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>share_name</para>
        /// </summary>
        [NameInMap("shareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The updater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
