// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteLakeStorageRequest : TeaModel {
        /// <summary>
        /// <para>The ADB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp*********</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the lake storage instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb-lake-cn-hangzhou-1aa1a1aa11</para>
        /// </summary>
        [NameInMap("LakeStorageId")]
        [Validation(Required=false)]
        public string LakeStorageId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
