// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FB0325E-8C37-5525-96AC-0333523170A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAdvanceConfigsResponseBodyResult> Result { get; set; }
        public class ListAdvanceConfigsResponseBodyResult : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>ONLINE: online configuration</para>
            /// </description></item>
            /// <item><description><para>ONLINE_CAVA: online Cava configuration</para>
            /// </description></item>
            /// <item><description><para>ONLINE_PLUGIN: online plugin</para>
            /// </description></item>
            /// <item><description><para>ONLINE_QUERY: query configuration</para>
            /// </description></item>
            /// <item><description><para>OFFLINE_DICT: offline dictionary configuration</para>
            /// </description></item>
            /// <item><description><para>OFFLINE_TABLE: offline table configuration</para>
            /// </description></item>
            /// <item><description><para>OFFLINE_COMMON: common offline configuration</para>
            /// </description></item>
            /// <item><description><para>OFFLINE_PLUGIN: offline plugin</para>
            /// </description></item>
            /// <item><description><para>OFFLINE_INDEX: index configuration</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("advanceConfigType")]
            [Validation(Required=false)]
            public string AdvanceConfigType { get; set; }

            /// <summary>
            /// <para>The configuration content. This parameter is returned for HTTP and Git requests.</para>
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
            /// <para>The ID of the user who created the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom Description</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>A list of files.</para>
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<ListAdvanceConfigsResponseBodyResultFiles> Files { get; set; }
            public class ListAdvanceConfigsResponseBodyResultFiles : TeaModel {
                /// <summary>
                /// <para>The absolute path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path/wpd/nae</para>
                /// </summary>
                [NameInMap("fullPathName")]
                [Validation(Required=false)]
                public string FullPathName { get; set; }

                /// <summary>
                /// <para>Specifies whether the file is a directory. Valid values:
                /// \- \<c>true\\</c>
                /// \- \<c>false\\</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isDir")]
                [Validation(Required=false)]
                public bool? IsDir { get; set; }

                /// <summary>
                /// <para>Specifies whether the file is a template. Valid values:
                /// \- \<c>true\\</c>
                /// \- \<c>false\\</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_name_1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the advanced configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_index</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the advanced configuration. Valid values:
            /// \- \<c>drafting\\</c>: The configuration is a draft.
            /// \- \<c>used\\</c>: The configuration is in use.
            /// \- \<c>unused\\</c>: The configuration is not in use.
            /// \- \<c>trash\\</c>: The configuration is being deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drafting</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631070464000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
