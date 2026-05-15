// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class BatchUpdateFileTagRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileInfos")]
        [Validation(Required=false)]
        public List<BatchUpdateFileTagRequestFileInfos> FileInfos { get; set; }
        public class BatchUpdateFileTagRequestFileInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file_3d5319366e2c46309f4c11cfbeacd5fd_10045951</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OVERWRITE</para>
        /// </summary>
        [NameInMap("UpdateMode")]
        [Validation(Required=false)]
        public string UpdateMode { get; set; }

    }

}
