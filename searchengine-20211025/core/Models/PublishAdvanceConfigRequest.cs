// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class PublishAdvanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The description of the advanced configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom configuration</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The file information.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<PublishAdvanceConfigRequestFiles> Files { get; set; }
        public class PublishAdvanceConfigRequestFiles : TeaModel {
            /// <summary>
            /// <para>The advanced configuration information.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public PublishAdvanceConfigRequestFilesConfig Config { get; set; }
            public class PublishAdvanceConfigRequestFilesConfig : TeaModel {
                /// <summary>
                /// <para>The file content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;url\&quot;:\&quot;<a href="http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar%5C%5C%22%7D">http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar\\&quot;}</a></para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The variable list.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public Dictionary<string, FilesConfigVariablesValue> Variables { get; set; }

            }

            /// <summary>
            /// <para>The folder name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/clusters</para>
            /// </summary>
            [NameInMap("dirName")]
            [Validation(Required=false)]
            public string DirName { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vector_question_schema.json</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>UPDATE: updates the file.</description></item>
            /// <item><description>DELETE: deletes the file.</description></item>
            /// </list>
            /// <para>Default value: UPDATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("operateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// <para>The OSS file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://opensearch/test.json</para>
            /// </summary>
            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// <para>The parent file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("parentFullPath")]
            [Validation(Required=false)]
            public string ParentFullPath { get; set; }

        }

    }

}
