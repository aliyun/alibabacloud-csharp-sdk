// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorListRequest : TeaModel {
        /// <summary>
        /// <para>The type of detection points used by the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PC: PC-based detection points.</para>
        /// </description></item>
        /// <item><description><para>MOBILE: mobile-based detection points.</para>
        /// </description></item>
        /// <item><description><para>FC: internal detection points.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("AgentGroup")]
        [Validation(Required=false)]
        public string AgentGroup { get; set; }

        /// <summary>
        /// <para>The keyword used to search for site monitoring tasks.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported based on the task name or task address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>site</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the site monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1ecd34a-8157-44d9-b060-14950837****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Normal.</para>
        /// </description></item>
        /// <item><description><para>2: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        /// <summary>
        /// <para>The type of the site monitoring task. CloudMonitor supports the following types: HTTP, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
