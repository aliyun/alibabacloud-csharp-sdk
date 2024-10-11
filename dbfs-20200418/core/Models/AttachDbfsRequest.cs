// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class AttachDbfsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>create_new_mount_point</para>
        /// </summary>
        [NameInMap("AttachMode")]
        [Validation(Required=false)]
        public string AttachMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/mnt/dbfs/dbfs-001</para>
        /// </summary>
        [NameInMap("AttachPoint")]
        [Validation(Required=false)]
        public string AttachPoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1ecr********5go2go</para>
        /// </summary>
        [NameInMap("ECSInstanceId")]
        [Validation(Required=false)]
        public string ECSInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbfs-v0WvA********tVEVcgJLg</para>
        /// </summary>
        [NameInMap("FsId")]
        [Validation(Required=false)]
        public string FsId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dbfs-pkg-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServerUrl")]
        [Validation(Required=false)]
        public string ServerUrl { get; set; }

    }

}
