// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UploadAppPluginVersionRequest : TeaModel {
        /// <summary>
        /// <para>The changelog description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x x x</para>
        /// </summary>
        [NameInMap("Changelog")]
        [Validation(Required=false)]
        public string Changelog { get; set; }

        /// <summary>
        /// <para>The description. This parameter is optional. If a non-empty value is specified, the description field in the main table is also updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The downloadable ZIP URL. This parameter is mutually exclusive with OssKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://sfile.chatglm.cn/chatglm4/file/a8/a87340a5ba.pdf">https://sfile.chatglm.cn/chatglm4/file/a8/a87340a5ba.pdf</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The extended JSON. This parameter is optional and uses the same format as the sandbox-synced extend field. If a non-empty value is specified, the extend field in the main table is also updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;deliveryNodeName\&quot;:\&quot;Delivery QA\&quot;,\&quot;deliveryNodeStatus\&quot;:\&quot;Finish\&quot;,\&quot;deliveryOperatorRole\&quot;:\&quot;Provider\&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The OSS key obtained after frontend direct upload. This parameter is mutually exclusive with DownloadUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backend/detection/objects/r-0008ujvfksltf5j45n81/task-000hckiuwyau0gwn17vq.jpg</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The gateway plug-in ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliplayer-react</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The new version number in semver format. The version must be greater than the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("PluginVersion")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

    }

}
