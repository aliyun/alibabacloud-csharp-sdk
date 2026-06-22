// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectClientEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectClientEventResponseBodyData Data { get; set; }
        public class GetFileProtectClientEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert notification level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no alert</description></item>
            /// <item><description>1: reminder</description></item>
            /// <item><description>2: suspicious</description></item>
            /// <item><description>3: high-risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public int? AlertLevel { get; set; }

            /// <summary>
            /// <para>The command line of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;touch&quot;,&quot;/usr/local/aaaa&quot;]</para>
            /// </summary>
            [NameInMap("CmdLine")]
            [Validation(Required=false)]
            public string CmdLine { get; set; }

            /// <summary>
            /// <para>The number of times the alert occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The process permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rwxr-xr-x</para>
            /// </summary>
            [NameInMap("FilePermission")]
            [Validation(Required=false)]
            public string FilePermission { get; set; }

            /// <summary>
            /// <para>The timestamp when the event first occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

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
            /// <para>3454</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz92q7m5hsbgfhdss***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.42.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The time when the event most recently occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            /// <summary>
            /// <para>The operation that the process performed on the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The operating system type.</para>
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
            /// <para>/bin/bash33</para>
            /// </summary>
            [NameInMap("ProcPath")]
            [Validation(Required=false)]
            public string ProcPath { get; set; }

            /// <summary>
            /// <para>The process ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3453</para>
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
            /// <para>The action of the blocking rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-000</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unhandled </description></item>
            /// <item><description>1: handled</description></item>
            /// <item><description>2: whitelisted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The user ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
