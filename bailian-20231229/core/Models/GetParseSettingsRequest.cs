// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetParseSettingsRequest : TeaModel {
        /// <summary>
        /// <para>The category ID, which is the <c>CategoryId</c> returned by <b>AddCategory</b>. To view the category ID, click the ID icon next to the category name on the Unstructured Data tab of the <a href="https://bailian.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

    }

}
