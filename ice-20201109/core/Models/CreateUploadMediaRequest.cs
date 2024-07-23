// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateUploadMediaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9e177cac2fb44f8b8c67b199fcc7bffd</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;Type\&quot;:\&quot;video\&quot;,\&quot;Name\&quot;:\&quot;test.mp4\&quot;,\&quot;Size\&quot;:108078336,\&quot;Ext\&quot;:\&quot;mp4\&quot;}</para>
        /// </summary>
        [NameInMap("FileInfo")]
        [Validation(Required=false)]
        public string FileInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;Title\&quot;: \&quot;UploadTest\&quot;, \&quot;Description\&quot;: \&quot;UploadImageTest\&quot;, \&quot;Tags\&quot;: \&quot;tag1,tag2\&quot;,\&quot;BusinessType\&quot;:\&quot;cover\&quot;}</para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;ProcessType\&quot;:\&quot;Workflow\&quot;,\&quot;ProcessID\&quot;:\&quot;74ba870f1a4873a3ba238e0bf6fa9***\&quot;}</para>
        /// </summary>
        [NameInMap("PostProcessConfig")]
        [Validation(Required=false)]
        public string PostProcessConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;StorageType\&quot;:\&quot;oss\&quot;,\&quot;StorageLocation\&quot;:\&quot;outin-***.oss-cn-shanghai.aliyuncs.com\&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
