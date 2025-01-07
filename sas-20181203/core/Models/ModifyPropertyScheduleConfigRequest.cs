// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPropertyScheduleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The new collection frequency of asset fingerprints. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled, which indicates that the asset fingerprints are not automatically or periodically collected.</description></item>
        /// <item><description><b>1</b>: collects asset fingerprints once an hour.</description></item>
        /// <item><description><b>3</b>: collects asset fingerprints once every 3 hours.</description></item>
        /// <item><description><b>12</b>: collects asset fingerprints once every 12 hours.</description></item>
        /// <item><description><b>24</b>: collects asset fingerprints once a day.</description></item>
        /// <item><description><b>168</b>: collects asset fingerprints once every 7 days.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// <para>The type of the asset fingerprints for which you want to modify the collection frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>scheduler_port_period</b>: listening port</description></item>
        /// <item><description><b>scheduler_process_period</b>: running process</description></item>
        /// <item><description><b>scheduler_account_period</b>: account</description></item>
        /// <item><description><b>scheduler_software_period</b>: software</description></item>
        /// <item><description><b>scheduler_cron_period</b>: scheduled task</description></item>
        /// <item><description><b>scheduler_sca_period</b>: middleware, database, or web service</description></item>
        /// <item><description><b>scheduler_autorun_period</b>: startup item</description></item>
        /// <item><description><b>scheduler_lkm_period</b>: kernel module</description></item>
        /// <item><description><b>scheduler_sca_proxy_period</b>: website</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scheduler_port_period</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
