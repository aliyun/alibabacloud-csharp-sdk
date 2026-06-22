// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<ListFileProtectEventResponseBodyEventList> EventList { get; set; }
        public class ListFileProtectEventResponseBodyEventList : TeaModel {
            /// <summary>
            /// <para>The alert notification level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: no alert</para>
            /// </description></item>
            /// <item><description><para>1: reminder</para>
            /// </description></item>
            /// <item><description><para>2: suspicious</para>
            /// </description></item>
            /// <item><description><para>3: high-risk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public int? AlertLevel { get; set; }

            /// <summary>
            /// <para>The command line of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;touch&quot;,&quot;/test/aaaa&quot;]</para>
            /// </summary>
            [NameInMap("CmdLine")]
            [Validation(Required=false)]
            public string CmdLine { get; set; }

            /// <summary>
            /// <para>The file path on which the process operates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/etc/pam.d/su</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The time when the event was handled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("HandleTime")]
            [Validation(Required=false)]
            public long? HandleTime { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>161757</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kyy-admin-01</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.40.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.22.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The most recent time when the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            /// <summary>
            /// <para>The operation performed by the process on the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The operating system type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows</description></item>
            /// <item><description><b>linux</b>: Linux.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The process path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/bin/sshpass</para>
            /// </summary>
            [NameInMap("ProcPath")]
            [Validation(Required=false)]
            public string ProcPath { get; set; }

            /// <summary>
            /// <para>The process permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rwxr-xr-x</para>
            /// </summary>
            [NameInMap("ProcPermission")]
            [Validation(Required=false)]
            public string ProcPermission { get; set; }

            /// <summary>
            /// <para>The process ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52636</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-rule-1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Unhandled. </description></item>
            /// <item><description>1: Manually handled.</description></item>
            /// <item><description>2: Whitelisted.</description></item>
            /// <item><description>3: Ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The UUID of the server associated with the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>94b44720-d982-4d20-a4e1-80a1a57b****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectEventResponseBodyPageInfo : TeaModel {
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
            /// <para>The maximum number of entries returned per page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-6BA51E212F80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
