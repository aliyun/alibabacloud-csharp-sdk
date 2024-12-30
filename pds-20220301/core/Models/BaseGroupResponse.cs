// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseGroupResponse : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc-111</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bj123</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b38b5681bd964950ad8bc0f8ea504793</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name-111</para>
        /// </summary>
        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("is_sync")]
        [Validation(Required=false)]
        public bool? IsSync { get; set; }

        [NameInMap("permission")]
        [Validation(Required=false)]
        public Dictionary<string, IDPermission> Permission { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
