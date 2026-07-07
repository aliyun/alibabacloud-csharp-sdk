// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class ParseSkillPackageRequest : TeaModel {
        /// <summary>
        /// <para>The OSS ETag returned after the file is uploaded to OSS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D9920C4858A60B70705A8765A******</para>
        /// </summary>
        [NameInMap("OssObjectETag")]
        [Validation(Required=false)]
        public string OssObjectETag { get; set; }

        /// <summary>
        /// <para>The OSS path of the skill package.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OssObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

    }

}
