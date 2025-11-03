// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListTransferFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The files.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ListTransferFilesResponseBodyFiles> Files { get; set; }
        public class ListTransferFilesResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The URL of the file icon.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>For image file types (.png, .jpg, .jpeg, .gif, .webp, and .svg), the URL of the specific image is returned.</para>
            /// </description></item>
            /// <item><description><para>For other file types, the URL of the default image is returned.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://app-center-icon-pre-hangzhou.oss-cn-hangzhou.aliyuncs.com/tenant">https://app-center-icon-pre-hangzhou.oss-cn-hangzhou.aliyuncs.com/tenant</a>****</para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trf-a213msf****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the object stored in OSS.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>A value is returned for this parameter only when the object is stored in a custom OSS bucket.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("OssFileName")]
            [Validation(Required=false)]
            public string OssFileName { get; set; }

            /// <summary>
            /// <para>The path of the object in the OSS bucket.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>A value is returned for this parameter only when the object is stored in a custom OSS bucket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>transfer/1244234/****</para>
            /// </summary>
            [NameInMap("OssFilePath")]
            [Validation(Required=false)]
            public string OssFilePath { get; set; }

            /// <summary>
            /// <para>The file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10853079</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The file status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DELETING</description></item>
            /// <item><description>DELETED</description></item>
            /// <item><description>UPLOADED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DELETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of <c>NextToken</c> is a pagination token, which can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
