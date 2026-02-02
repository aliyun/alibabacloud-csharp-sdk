// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeQosRulesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-cxj99qb8d34vo****</para>
        /// </summary>
        [NameInMap("NetworkPackageId")]
        [Validation(Required=false)]
        public string NetworkPackageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QosRuleName")]
        [Validation(Required=false)]
        public string QosRuleName { get; set; }

    }

}
