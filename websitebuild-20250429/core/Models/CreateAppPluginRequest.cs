// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppPluginRequest : TeaModel {
        /// <summary>
        /// <para>The category of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Depth\&quot;: 4, \&quot;ParentCategoryId\&quot;: 5281, \&quot;Name\&quot;: \&quot;1\&quot;, \&quot;CategoryId\&quot;: 5282, \&quot;CreateTime\&quot;: \&quot;2025-08-26 10:20:37\&quot;}</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The description of the skill. The description must be 10 to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The URL of the downloadable ZIP file. Specify either this parameter or OssKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv6-inner/common/v1.20230608104522.dex?Expires=1753324652&OSSAccessKeyId=x6R87i97yKeKRggz&Signature=IwS6V56TlgjcX0AgikXLvf3CVtw%3D">http://geoip-sdk-user.oss-cn-zhangjiakou.aliyuncs.com/product/v1/ipv6-inner/common/v1.20230608104522.dex?Expires=1753324652&amp;OSSAccessKeyId=x6R87i97yKeKRggz&amp;Signature=IwS6V56TlgjcX0AgikXLvf3CVtw%3D</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The extended JSON data. The format is the same as the extend parameter synchronized with the sandbox. If this parameter is not empty, it is saved to the database. This parameter is optional.</para>
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
        /// <para>The Object Storage Service (OSS) key generated after a direct upload from the frontend. Specify either this parameter or DownloadUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backend/detection/objects/r-0008ujvfksltf5j45n81/task-000hckiuwyau0gwn17vq.jpg</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The unique identifier of the skill. The identifier must be 3 to 64 characters in length and can contain only lowercase letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1bae9ceaceea432d91c7069fab0dfc02</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The name of the skill. The name must be 2 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alisecguard</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// <para>The version number of the plug-in. The version number must be in the Semantic Versioning (SemVer) format. Default value: 0.1.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.6</para>
        /// </summary>
        [NameInMap("PluginVersion")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// <para>The tags of the skill. Separate multiple tags with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The visibility of the skill. Default value: private.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
