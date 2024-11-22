// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class EnableCustomScenePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850508.html">DescribeCustomScenePolicies</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

    }

}
