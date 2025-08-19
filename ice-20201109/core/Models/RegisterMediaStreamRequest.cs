// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class RegisterMediaStreamRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the media asset in another service. The URL is associated with the ID of the media asset in IMS. The URL cannot be modified once registered.</para>
        /// <para>Set this parameter to the OSS URL of the media asset. The following formats are supported:</para>
        /// <para>http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</para>
        /// <para>oss://example-bucket/example.mp4: In this format, it is considered by default that the region of the OSS bucket in which the media asset resides is the same as the region in which IMS is activated.</para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5e778ec0027b71ed80a8909598506***</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("StreamTags")]
        [Validation(Required=false)]
        public string StreamTags { get; set; }

        /// <summary>
        /// <para>The user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://test.test.com%22%7D">http://test.test.com&quot;}</a>, &quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
