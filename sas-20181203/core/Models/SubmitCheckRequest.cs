// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitCheckRequest : TeaModel {
        /// <summary>
        /// <para>The policy ID. This parameter takes effect only when ScanRange is set to POLICY. You can obtain the value by calling the ListCheckConfigs operation. If this parameter is not specified or is set to default, the scan is triggered based on the system default policy. If the default policy does not exist, NoDefaultStrategy is returned. If another value is specified, the scan is triggered based on the check items of the specified policy. If the policy does not exist or does not belong to the current account, IllegalParam is returned. This parameter is ignored when ScanRange is set to FULL or FREE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22222f91-57af-4907-87f1-f9046da****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the member accounts of the resource folder belong.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The check scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: Scans all check items.</description></item>
        /// <item><description><b>POLICY</b>: Scans check items of custom configurations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POLICY</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRange { get; set; }

        /// <summary>
        /// <para>The source of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>YAO_CHI</b>: ApsaraDB console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>YAO_CHI</para>
        /// </summary>
        [NameInMap("TaskSource")]
        [Validation(Required=false)]
        public string TaskSource { get; set; }

    }

}
