// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveGroupRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AdminUserIds")]
        [Validation(Required=false)]
        public List<string> AdminUserIds { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk in Cloud Drive Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-532033****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The ID of the team.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7f4bbccda0cf40bb85981b65fb5e****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The size of the cloud disk in Cloud Drive Service. Unit: bytes. The size is unlimited.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

    }

}
