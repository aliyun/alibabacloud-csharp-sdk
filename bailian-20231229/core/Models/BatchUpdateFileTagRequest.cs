// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class BatchUpdateFileTagRequest : TeaModel {
        /// <summary>
        /// <para>The list of documents to update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileInfos")]
        [Validation(Required=false)]
        public List<BatchUpdateFileTagRequestFileInfos> FileInfos { get; set; }
        public class BatchUpdateFileTagRequestFileInfos : TeaModel {
            /// <summary>
            /// <para>The file ID in the data center. On the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page, click the ID icon next to the file name to obtain the ID.</para>
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
            /// <item><description>The list of tags associated with the file. You can specify up to 100 tags, and the total character length of all tags cannot exceed 700.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <para>The update mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APPEND: appends tags to existing tags.</description></item>
        /// <item><description>OVERWRITE: overwrites existing tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OVERWRITE</para>
        /// </summary>
        [NameInMap("UpdateMode")]
        [Validation(Required=false)]
        public string UpdateMode { get; set; }

    }

}
