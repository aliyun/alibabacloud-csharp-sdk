// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListDNAFilesResponseBody : TeaModel {
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<ListDNAFilesResponseBodyFileList> FileList { get; set; }
        public class ListDNAFilesResponseBodyFileList : TeaModel {
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public ListDNAFilesResponseBodyFileListInputFile InputFile { get; set; }
            public class ListDNAFilesResponseBodyFileListInputFile : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>example-bucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-cn-beijing</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example-****.mp4</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ae0fd49c0840e14daf0d66a75b83****</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ae0fd49c0840e14daf0d66a75b83****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2AE89FA5-E620-56C7-9B80-75D09757385A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
