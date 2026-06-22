// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVirusScanMachineEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the alert events.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVirusScanMachineEventResponseBodyData> Data { get; set; }
        public class ListVirusScanMachineEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the exception event.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListVirusScanMachineEventResponseBodyDataDetails> Details { get; set; }
            public class ListVirusScanMachineEventResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <para>The display type of valueDisplay.
                /// Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>download_url</b>: download link.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>download_url</para>
                /// </summary>
                [NameInMap("InfoType")]
                [Validation(Required=false)]
                public string InfoType { get; set; }

                /// <summary>
                /// <para>The display name of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Trojan Path</para>
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// <para>The display format of the exception event details.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>: plain text</description></item>
                /// <item><description><b>html</b>: rich text.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>html</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The additional attribute information of the exception event.
                /// For example, the logon time or logon location of an unusual logon alert, or the trojan file path or trojan type of an alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>getopt</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// <para>The ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>911273</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <para>The name (subtype) of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>恶意脚本代码执行</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

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
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.42.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The timestamp of the last occurrence, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682046733628</para>
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// <para>The risk level of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>serious</b>: Critical.</description></item>
            /// <item><description><b>suspicious</b>: Suspicious.</description></item>
            /// <item><description><b>remind</b>: Reminder.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListVirusScanMachineEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListVirusScanMachineEventResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of alert events returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DAEF40F-8E1A-550D-8793-99C61C401DD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
