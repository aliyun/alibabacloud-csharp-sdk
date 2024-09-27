// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MigrateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*******.oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("oss_bucket_endpoint")]
        [Validation(Required=false)]
        public string OssBucketEndpoint { get; set; }

        /// <summary>
        /// <para>The name of the Object Storage Service (OSS) bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket-****</para>
        /// </summary>
        [NameInMap("oss_bucket_name")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

    }

}
