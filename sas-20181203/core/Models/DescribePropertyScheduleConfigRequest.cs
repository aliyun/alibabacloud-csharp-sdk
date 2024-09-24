// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScheduleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset fingerprints. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>scheduler_port_period</b>: listening port</description></item>
        /// <item><description><b>scheduler_process_period</b>: running process</description></item>
        /// <item><description><b>scheduler_account_period</b>: account</description></item>
        /// <item><description><b>scheduler_software_period</b>: software</description></item>
        /// <item><description><b>scheduler_cron_period</b>: scheduled task</description></item>
        /// <item><description><b>scheduler_sca_period</b>: middleware</description></item>
        /// <item><description><b>scheduler_autorun_period</b>: startup item</description></item>
        /// <item><description><b>scheduler_lkm_period</b>: kernel module</description></item>
        /// <item><description><b>scheduler_sca_proxy_period</b>: website</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scheduler_autorun_period</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
