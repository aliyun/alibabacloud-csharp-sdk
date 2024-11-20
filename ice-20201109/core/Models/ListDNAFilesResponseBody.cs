// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListDNAFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried files.</para>
        /// </summary>
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<ListDNAFilesResponseBodyFileList> FileList { get; set; }
        public class ListDNAFilesResponseBodyFileList : TeaModel {
            /// <summary>
            /// <para>The Object Storage Service (OSS) information about the input file.</para>
            /// </summary>
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public ListDNAFilesResponseBodyFileListInputFile InputFile { get; set; }
            public class ListDNAFilesResponseBodyFileListInputFile : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket in which the input file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-bucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The OSS region in which the input file resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-beijing</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The name of the OSS object that is used as the input file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-****.mp4</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <para>The primary key of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ae0fd49c0840e14daf0d66a75b83****</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae0fd49c0840e14daf0d66a75b83****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE89FA5-E620-56C7-9B80-75D09757385A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
