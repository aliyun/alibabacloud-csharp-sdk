// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteDynamicTagGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the tag rule.</para>
        /// <para>For information about how to obtain the ID of a tag rule, see <a href="https://help.aliyun.com/document_detail/150126.html">DescribeDynamicTagRuleList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b882d9a-5117-42e2-9d0c-4749a0c6****</para>
        /// </summary>
        [NameInMap("DynamicTagRuleId")]
        [Validation(Required=false)]
        public string DynamicTagRuleId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
