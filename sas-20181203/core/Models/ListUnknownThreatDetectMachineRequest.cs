// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectMachineRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The status of the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: pending</description></item>
        /// <item><description><b>2</b>: ignored</description></item>
        /// <item><description><b>4</b>: confirmed</description></item>
        /// <item><description><b>8</b>: marked as false positive</description></item>
        /// <item><description><b>16</b>: processing</description></item>
        /// <item><description><b>32</b>: handled</description></item>
        /// <item><description><b>64</b>: expired</description></item>
        /// <item><description><b>604</b>: marked as false positive by the system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public int? EventStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name or IP address of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ecs</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The running status of the server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>monitoring</b>: alerting</description></item>
        /// <item><description><b>blocking</b>: blocking</description></item>
        /// <item><description><b>studying</b>: learning</description></item>
        /// <item><description><b>study_finish</b>: learning completed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>studying</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The whitelist mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hash</b>: the hash of the process</description></item>
        /// <item><description><b>path</b>: the path of the process</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("StudyMode")]
        [Validation(Required=false)]
        public string StudyMode { get; set; }

        /// <summary>
        /// <para>The end time of the time range when the model was created. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1768891966346</para>
        /// </summary>
        [NameInMap("StudyTimeEnd")]
        [Validation(Required=false)]
        public long? StudyTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the time range when the model was created. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1768891966344</para>
        /// </summary>
        [NameInMap("StudyTimeStart")]
        [Validation(Required=false)]
        public long? StudyTimeStart { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d2d94e8b-bb25-4744-8004-1e08a53c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
