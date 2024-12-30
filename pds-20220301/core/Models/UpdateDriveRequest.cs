// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateDriveRequest : TeaModel {
        /// <summary>
        /// <para>The description of the drive. The description can be up to 1,024 characters in length.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The name of the drive. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_drive</para>
        /// </summary>
        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// <para>The owner of the drive. Note: You can modify the owner of a personal drive only by using an AccessKey pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The state of the drive. Valid values:</para>
        /// <para>enabled and disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total size of the drive. Unit: bytes. A value of -1 specifies that the size is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

    }

}
