// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MigrateClusterRequest : Darabonba.Model {
        /// <summary>
        /// <para>The bucket endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*******.oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("oss_bucket_endpoint")]
        [Validation(Required=false)]
        public string OssBucketEndpoint { get; set; }

        /// <summary>
        /// <para>The bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket-****</para>
        /// </summary>
        [NameInMap("oss_bucket_name")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

    }

}

