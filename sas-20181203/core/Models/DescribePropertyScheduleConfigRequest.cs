// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScheduleConfigRequest : TeaModel {
        /// <summary>
        /// The type of the asset fingerprints to query. Valid values:
        /// 
        /// *   **scheduler_port_period**: listening port
        /// *   **scheduler_process_period**: running process
        /// *   **scheduler_account_period**: account
        /// *   **scheduler_software_period**: software
        /// *   **scheduler_cron_period**: scheduled task
        /// *   **scheduler_sca_period**: middleware
        /// *   **scheduler_autorun_period**: startup item
        /// *   **scheduler_lkm_period**: kernel module
        /// *   **scheduler_sca_proxy_period**: website
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
