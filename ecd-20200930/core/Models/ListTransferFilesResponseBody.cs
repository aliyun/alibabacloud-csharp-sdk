// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListTransferFilesResponseBody : TeaModel {
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ListTransferFilesResponseBodyFiles> Files { get; set; }
        public class ListTransferFilesResponseBodyFiles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://app-center-icon-pre-hangzhou.oss-cn-hangzhou.aliyuncs.com/tenant">https://app-center-icon-pre-hangzhou.oss-cn-hangzhou.aliyuncs.com/tenant</a>****</para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>trf-a213msf****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OssFileName")]
            [Validation(Required=false)]
            public string OssFileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>transfer/1244234/****</para>
            /// </summary>
            [NameInMap("OssFilePath")]
            [Validation(Required=false)]
            public string OssFilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10853079</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DELETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>txt</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
