// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestoreJobsRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The unique identifier of the server on which the restoration task is run. For example, you can use the IP address or the name of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the restoration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RUNNING</b>: The task is running.</description></item>
        /// <item><description><b>COMPLETE</b>: The task is complete.</description></item>
        /// <item><description><b>FAILED</b>: The task fails.</description></item>
        /// <item><description><b>CANCELING</b>: The task is being canceled.</description></item>
        /// <item><description><b>CANCELED</b>: The task is canceled.</description></item>
        /// <item><description><b>PARTIAL_COMPLETE</b>: The task is partially successful.</description></item>
        /// <item><description><b>CREATED</b>: The task is created but is not run.</description></item>
        /// <item><description><b>EXPIRED</b>: The task is not updated.</description></item>
        /// <item><description><b>QUEUED</b>: The task is waiting to be run.</description></item>
        /// <item><description><b>CLIENT_DELETED</b>: The task fails because the anti-ransomware agent is uninstalled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
