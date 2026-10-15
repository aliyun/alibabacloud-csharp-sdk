// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppPluginRequest : TeaModel {
        /// <summary>
        /// <para>The category of the plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Depth\&quot;: 4, \&quot;ParentCategoryId\&quot;: 5281, \&quot;Name\&quot;: \&quot;1\&quot;, \&quot;CategoryId\&quot;: 5282, \&quot;CreateTime\&quot;: \&quot;2025-08-26 10:20:37\&quot;}</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The description of the plug-in. The value must be 10 to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The downloadable ZIP URL. This parameter is mutually exclusive with OssKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv6-inner/common/v1.20230608104522.dex?Expires=1753324652&OSSAccessKeyId=x6R87i97yKeKRggz&Signature=IwS6V56TlgjcX0AgikXLvf3CVtw%3D">http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv6-inner/common/v1.20230608104522.dex?Expires=1753324652&amp;OSSAccessKeyId=x6R87i97yKeKRggz&amp;Signature=IwS6V56TlgjcX0AgikXLvf3CVtw%3D</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The extended JSON. This parameter is optional and uses the same format as the extend field in sandbox synchronization. If this parameter is not empty, the value is written to the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;user_device_id\&quot;:\&quot;6bef45cb0c76de284d24de074c088b73\&quot;}\n</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The URL of the icon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>The OSS key after frontend direct upload. This parameter is mutually exclusive with DownloadUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backend/detection/objects/r-0008ujvfksltf5j45n81/task-000hckiuwyau0gwn17vq.jpg</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The unique identifier of the plug-in. The value can contain lowercase letters, digits, and hyphens (-), and must be 3 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1bae9ceaceea432d91c7069fab0dfc02</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The name of the plug-in. The value must be 2 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alisecguard</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// <para>The version number in semver format. Default value: 0.1.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.6</para>
        /// </summary>
        [NameInMap("PluginVersion")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// <para>The tags, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The visibility of the plug-in. Default value: private.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
