// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCustomScenePoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Valid values: 1 to 100000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: 5, 10, and 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the policy, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850233.html">ListWafRulesets</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

    }

}
