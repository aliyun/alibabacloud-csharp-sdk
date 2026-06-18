// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class BatchUpdateFileTagRequest : TeaModel {
        /// <summary>
        /// <para>A list of files to update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileInfos")]
        [Validation(Required=false)]
        public List<BatchUpdateFileTagRequestFileInfos> FileInfos { get; set; }
        public class BatchUpdateFileTagRequestFileInfos : TeaModel {
            /// <summary>
            /// <para>The file ID. To get this ID, go to the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">application data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">application data</a> page and click the ID icon next to the file name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file_3d5319366e2c46309f4c11cfbeacd5fd_10045951</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>A list of up to 100 tags to associate with the file. The total length of all tags cannot exceed 700 characters.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <para>The update mode. Valid values are APPEND and OVERWRITE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OVERWRITE</para>
        /// </summary>
        [NameInMap("UpdateMode")]
        [Validation(Required=false)]
        public string UpdateMode { get; set; }

    }

}
