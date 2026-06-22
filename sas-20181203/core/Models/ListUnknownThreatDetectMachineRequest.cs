// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectMachineRequest : TeaModel {
        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The server name or IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ecs</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The status of the machine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>monitoring</b>: Monitoring</para>
        /// </description></item>
        /// <item><description><para><b>blocking</b>: Blocking</para>
        /// </description></item>
        /// <item><description><para><b>studying</b>: Learning</para>
        /// </description></item>
        /// <item><description><para><b>study_finish</b>: Learning complete</para>
        /// </description></item>
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
        /// <item><description><para><b>hash</b>: process hash</para>
        /// </description></item>
        /// <item><description><para><b>path</b>: process path</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("StudyMode")]
        [Validation(Required=false)]
        public string StudyMode { get; set; }

        /// <summary>
        /// <para>The end of the time range for model creation, specified as a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1768891966346</para>
        /// </summary>
        [NameInMap("StudyTimeEnd")]
        [Validation(Required=false)]
        public long? StudyTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the time range for model creation, specified as a timestamp in milliseconds.</para>
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
