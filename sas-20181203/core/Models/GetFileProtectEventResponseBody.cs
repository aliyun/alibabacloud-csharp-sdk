// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectEventResponseBodyData Data { get; set; }
        public class GetFileProtectEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert notification level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: No alert.</para>
            /// </description></item>
            /// <item><description><para>1: Reminder.</para>
            /// </description></item>
            /// <item><description><para>2: Suspicious.</para>
            /// </description></item>
            /// <item><description><para>3: High-risk.</para>
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
            /// <para>The event command line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;touch&quot;,&quot;/usr/local/aaaa&quot;]</para>
            /// </summary>
            [NameInMap("CmdLine")]
            [Validation(Required=false)]
            public string CmdLine { get; set; }

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
            /// <para>The time when the event was handled. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("HandleTime")]
            [Validation(Required=false)]
            public long? HandleTime { get; set; }

            /// <summary>
            /// <para>The unique ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55037</para>
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
            /// <para>172.16.XX.XX</para>
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
            /// <para>The timestamp when the event most recently occurred. The value is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <item><description><b>windows</b>: Windows.</description></item>
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
            /// <para>[&quot;test&quot;]</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

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
            /// <para>The user ID that started the current process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username that started the current process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49f1360f-62c8-4b48-a24c-5cc317656419</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
