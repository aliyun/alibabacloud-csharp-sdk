// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFileRequest : TeaModel {
        /// <summary>
        /// <para>The primary key ID of the category to which the document is uploaded. This parameter corresponds to the <c>CategoryId</c>&lt;props=&quot;china&quot;&gt; returned by the <a href="https://www.alibabacloud.com/help/zh/model-studio/developer-reference/api-bailian-2023-12-29-addcategory">AddCategory</a> operation. You can also click the ID icon next to the category name on the Unstructured Data tab of the <a href="https://bailian.console.alibabacloud.com/#/data-center">Data Management</a> page to view the ID. You can set the parameter to default, which specifies the Default Category created by the system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee3510024405</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The lease ID, which corresponds to the <c>FileUploadLeaseId</c> parameter returned by the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68abd1dea7b6404d8f7d7b9f7fbd332d.1716698936847</para>
        /// </summary>
        [NameInMap("LeaseId")]
        [Validation(Required=false)]
        public string LeaseId { get; set; }

        /// <summary>
        /// <para>The parser. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>DASHSCOPE_DOCMIND: Intelligent document parsing by Alibaba Cloud.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DASHSCOPE_DOCMIND</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>A list of tags associated with the document. The default value is null, which means no tags. You can specify up to 10 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
