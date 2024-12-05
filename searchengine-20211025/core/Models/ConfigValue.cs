// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ConfigValue : TeaModel {
        /// <summary>
        /// <para>The description of the offline configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The files to be modified.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<ConfigValueFiles> Files { get; set; }
        public class ConfigValueFiles : TeaModel {
            /// <summary>
            /// <para>The operation type. Valid values: UPDATE and DELETE. Default value: UPDATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("operateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// <para>The path of the parent directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("parentFullPath")]
            [Validation(Required=false)]
            public string ParentFullPath { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/intervene_dict/中文-通用分析器.dict</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The configuration to be modified.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ConfigValueFilesConfig Config { get; set; }
            public class ConfigValueFilesConfig : TeaModel {
                /// <summary>
                /// <para>The file content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$dictContent</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The variables.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public Dictionary<string, ConfigValueFilesConfigVariablesValue> Variables { get; set; }

            }

            /// <summary>
            /// <para>The directory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("dirName")]
            [Validation(Required=false)]
            public string DirName { get; set; }

        }

    }

}
