// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateDriveResponseBody : TeaModel {
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        [NameInMap("drive_type")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("used_size")]
        [Validation(Required=false)]
        public long? UsedSize { get; set; }

    }

}
