// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAgenticSecurityPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include archived policies in the user policy query scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Includes archived policies.</description></item>
        /// <item><description>false: Does not include archived policies.
        /// Default value: false. When you query archived policies, do not specify PolicyStatus. If you specify ON or OFF, only user policies in the corresponding state are returned. This parameter does not affect system default policies.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IncludeArchived")]
        [Validation(Required=false)]
        public bool? IncludeArchived { get; set; }

        /// <summary>
        /// <para>The page number for querying user policies. Pages start from 1. Default value: 1. Only user policies are paginated. System default policies are returned separately in each call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The filter condition for the user policy status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ON: The policy is enabled.</description></item>
        /// <item><description>OFF: The policy is disabled.
        /// If this parameter is not specified or contains only whitespace characters, policies are not filtered by status. You cannot specify ARCHIVED. To query archived user policies, do not specify this parameter and set IncludeArchived to true. This parameter does not affect system default policies.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// <para>The number of user policies to query on each page. Valid values: 1 to 100. Default value: 20. In addition, each call returns up to Size enabled system default policies. Therefore, the number of returned Data entries may be greater than Size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
