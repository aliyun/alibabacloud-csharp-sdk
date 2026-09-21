// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The Asset Type to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: queries all ECS servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether the fuzzy query field supports automatic matching. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportAutoTag")]
        [Validation(Required=false)]
        public bool? SupportAutoTag { get; set; }

        /// <summary>
        /// <para>The fuzzy match value entered when querying assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.96</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
