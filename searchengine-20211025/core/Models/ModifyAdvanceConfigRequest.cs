// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyAdvanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The content of the configuration. This parameter is not empty for HTTP and Git requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;url\&quot;:\&quot;<a href="http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar%5C%5C%22%7D">http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar\\&quot;}</a></para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The type of the configuration content. Valid values: FILE, GIT, HTTP, and ODPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The description of the advanced configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom Configuration</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The list of files.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<ModifyAdvanceConfigRequestFiles> Files { get; set; }
        public class ModifyAdvanceConfigRequestFiles : TeaModel {
            /// <summary>
            /// <para>The full path of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/cluster.json</para>
            /// </summary>
            [NameInMap("fullPathName")]
            [Validation(Required=false)]
            public string FullPathName { get; set; }

            /// <summary>
            /// <para>Indicates whether the path specifies a directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// <para>Indicates whether the file is a template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The name of the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****_offline_adv_edit</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status of the configuration. Valid values: drafting, used, unused, and trash.</para>
        /// 
        /// <b>Example:</b>
        /// <para>used</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the configuration was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-02-27T07:50:55Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
