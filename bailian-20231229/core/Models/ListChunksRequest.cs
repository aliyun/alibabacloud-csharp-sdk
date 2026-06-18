// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListChunksRequest : TeaModel {
        /// <summary>
        /// <para>An array of field names used to filter non-private fields (those not prefixed with an underscore _) in the Metadata field returned by this operation. By default, Fields is empty, and all non-private fields in Metadata are returned. To return only specific non-private fields in Metadata, such as title, pass title in this parameter.</para>
        /// <para>Default value: empty.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The file ID, which is the <c>FileId</c> returned by the <b>AddFile</b> operation. This field is not required for data query or image Q&amp;A knowledge bases. This field is required for document search or audio/video search knowledge bases. You can also obtain the file ID by clicking the ID icon next to the file name on the Files tab of <a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>. You can use the file ID to filter the returned chunks. Default value: empty.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The file ID, which is the <c>FileId</c> returned by the <b>AddFile</b> operation. This field is not required for data query or image Q&amp;A knowledge bases. This field is required for document search knowledge bases. You can also obtain the file ID by clicking the ID icon next to the file name on the Files tab of
        /// <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. You can use the file ID to filter the returned chunks. Default value: empty.</para>
        /// <para>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file_5f03dfea56da4050ab68d61871fc4cb3_xxxxxxxx</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The file ID field in the legacy Model Studio SDK. The usage and default value are identical to those of the <c>FileId</c> field. If you are using the following versions (or later) of the Model Studio SDK, use the <c>FileId</c> field instead. If you are using the SWIFT Model Studio SDK, continue to use this field.</para>
        /// <list type="bullet">
        /// <item><description>Java (async): 1.0.18</description></item>
        /// <item><description>Java: 1.10.2</description></item>
        /// <item><description>TypeScript: 1.10.2</description></item>
        /// <item><description>Go: 1.10.2</description></item>
        /// <item><description>PHP: 1.10.2</description></item>
        /// <item><description>Python: 1.10.2</description></item>
        /// <item><description>C#: 1.10.2</description></item>
        /// <item><description>C++: 1.10.17</description></item>
        /// </list>
        /// <remarks>
        /// <para><b>How to check the Model Studio SDK version</b>: Visit the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK center</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK center</a>, click &quot;<b>Install</b>&quot; in the left-side navigation pane, set the API version to &quot;<b>2023-12-29</b>&quot;, select your programming language, and then click &quot;<b>History Versions</b>&quot; to view the version.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>file_5f03dfea56da4050ab68d61871fc4cb3_xxxxxxxx</para>
        /// </summary>
        [NameInMap("Filed")]
        [Validation(Required=false)]
        public string Filed { get; set; }

        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>otoru9xxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The page number to query. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of text chunks to display per page in a paged query. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
