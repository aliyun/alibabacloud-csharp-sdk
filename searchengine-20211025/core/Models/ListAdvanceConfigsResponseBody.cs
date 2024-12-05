// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FB0325E-8C37-5525-96AC-0333523170A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The advanced configurations.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAdvanceConfigsResponseBodyResult> Result { get; set; }
        public class ListAdvanceConfigsResponseBodyResult : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description>The type of the advanced configuration. Valid values: -ONLINE: online configuration</description></item>
            /// <item><description>\-ONLINE_CAVA: online Cava configuration</description></item>
            /// <item><description>\-ONLINE_PLUGIN: online plug-in configuration</description></item>
            /// <item><description>\-ONLINE_QUERY: query configuration</description></item>
            /// <item><description>\-OFFLINE_DICT: offline dictionary configuration</description></item>
            /// <item><description>\-OFFLINE_TABLE: offline table configuration</description></item>
            /// <item><description>\-OFFLINE_COMMON: offline configuration</description></item>
            /// <item><description>\-OFFLINE_PLUGIN: offline plug-in configuration</description></item>
            /// <item><description>\-OFFLINE_INDEX: index configuration</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("advanceConfigType")]
            [Validation(Required=false)]
            public string AdvanceConfigType { get; set; }

            /// <summary>
            /// <para>The content of the advanced configuration that is returned.</para>
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
            /// <para>The Alibaba Cloud account ID of the user who created the advanced configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the advanced configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The files.</para>
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<ListAdvanceConfigsResponseBodyResultFiles> Files { get; set; }
            public class ListAdvanceConfigsResponseBodyResultFiles : TeaModel {
                /// <summary>
                /// <para>The absolute path in which the file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path/wpd/nae</para>
                /// </summary>
                [NameInMap("fullPathName")]
                [Validation(Required=false)]
                public string FullPathName { get; set; }

                /// <summary>
                /// <para>Indicates whether the file is a directory. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isDir")]
                [Validation(Required=false)]
                public bool? IsDir { get; set; }

                /// <summary>
                /// <para>Indicates whether the file is a template. Valid values: true and false.</para>
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
            /// <para>The status of the advanced configuration. Valid values: drafting: The advanced configuration is in the draft state. used: The advanced configuration is being used. unused: The advanced configuration is not used. trash: The advanced configuration is being deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drafting</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the advanced configuration was updated.</para>
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
