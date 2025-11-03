// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateScreenshotRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phone instances. You can create multiple snapshots simultaneously.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket. The name must start with &quot;cloudphone-saved-bucket-&quot;. The OSS bucket and the cloud phone instance must be in the same region. If you leave this parameter empty, the system will create a default OSS bucket named “cloudphone-saved-bucket-{Region of the cloud phone instance}-{AliUid}.”</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudphone-saved-bucket-cn-shanghai-default</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("ScreenshotId")]
        [Validation(Required=false)]
        public string ScreenshotId { get; set; }

        /// <summary>
        /// <para>Specifies whether to bypass the snapshot policy control. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipCheckPolicyConfig")]
        [Validation(Required=false)]
        public string SkipCheckPolicyConfig { get; set; }

    }

}
