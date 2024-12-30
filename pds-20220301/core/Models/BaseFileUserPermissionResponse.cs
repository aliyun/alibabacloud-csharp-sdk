// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseFileUserPermissionResponse : TeaModel {
        [NameInMap("can_access")]
        [Validation(Required=false)]
        public bool? CanAccess { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("disinherit_sub_group")]
        [Validation(Required=false)]
        public bool? DisinheritSubGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bj23</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("file_full_path")]
        [Validation(Required=false)]
        public string FileFullPath { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("identity")]
        [Validation(Required=false)]
        public Identity Identity { get; set; }

        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
