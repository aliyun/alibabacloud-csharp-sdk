// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseDriveResponse : TeaModel {
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<string> ActionList { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccp</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("delta_enabled")]
        [Validation(Required=false)]
        public bool? DeltaEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccp team drive</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hz999</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccpdrive</para>
        /// </summary>
        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("drive_type")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        [NameInMap("encrypt_data_access")]
        [Validation(Required=false)]
        public bool? EncryptDataAccess { get; set; }

        [NameInMap("encrypt_mode")]
        [Validation(Required=false)]
        public string EncryptMode { get; set; }

        [NameInMap("is_handover")]
        [Validation(Required=false)]
        public bool? IsHandover { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccp</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("path_status")]
        [Validation(Required=false)]
        public string PathStatus { get; set; }

        [NameInMap("permission")]
        [Validation(Required=false)]
        public Dictionary<string, IDPermission> Permission { get; set; }

        [NameInMap("relative_path")]
        [Validation(Required=false)]
        public string RelativePath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("store_id")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>102400</para>
        /// </summary>
        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("used_size")]
        [Validation(Required=false)]
        public long? UsedSize { get; set; }

    }

}
