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
        /// <para>oss\://example-bucket/example.mp4: In this format, it is considered by default that the region of the OSS bucket in which the media asset resides is the same as the region in which IMS is activated.</para>
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

        /// <summary>
        /// <para>Custom stream tags used to identify transcoding streams.</para>
        /// <para>After the media stream is registered, you can invoke <a href="https://help.aliyun.com/zh/ims/developer-reference/api-ice-2020-11-09-getplayinfo?spm=a2c4g.11186623.help-menu-193643.d_5_0_3_1_4.56dc5a11JzNEVj">GetPlayInfo</a> to retrieve this tag value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;value1&quot;}</para>
        /// </summary>
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
