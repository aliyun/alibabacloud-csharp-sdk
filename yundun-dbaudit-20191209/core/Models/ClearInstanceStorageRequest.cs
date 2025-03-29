// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20191209.Models
{
    public class ClearInstanceStorageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbaudit-cn-78v1gc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbaudit-audit-dbaudit-cn-78v1gc****</para>
        /// </summary>
        [NameInMap("StorageCategory")]
        [Validation(Required=false)]
        public string StorageCategory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbaudit-cn-78v1gc****</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public string StorageSpace { get; set; }

    }

}
