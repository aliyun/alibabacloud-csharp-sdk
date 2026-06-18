// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the category. The name must be 1 to 20 characters long. It can contain Unicode letters, such as English letters and Chinese characters, along with digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>产品清单</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The type of the category. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>UNSTRUCTURED: A category.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The ID of the connector instance. You can obtain the ID from the Alibaba Cloud Model Studio console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conn_xxxx</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The ID of the parent category under which the new category is created. If you leave this parameter empty, a top-level category is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee3xxxxxxxx</para>
        /// </summary>
        [NameInMap("ParentCategoryId")]
        [Validation(Required=false)]
        public string ParentCategoryId { get; set; }

    }

}
