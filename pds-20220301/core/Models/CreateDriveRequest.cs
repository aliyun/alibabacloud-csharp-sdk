// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateDriveRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the drive is the default drive. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("default")]
        [Validation(Required=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// <para>The description of the drive. The description can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drive for test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the drive. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_drive</para>
        /// </summary>
        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// <para>The type of the drive. Set the value to normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("drive_type")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        /// <summary>
        /// <para>The owner of the drive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b3d7245c159488da17d081ad6c64687</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The type of the owner. Valid values:</para>
        /// <para>user and group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The state of the drive. Valid values:</para>
        /// <para>enabled and disabled.</para>
        /// <para>Default value: enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total size of the drive. Unit: bytes. By default, the size is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

    }

}
