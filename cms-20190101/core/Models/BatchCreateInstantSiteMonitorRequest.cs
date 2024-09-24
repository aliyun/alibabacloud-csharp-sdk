// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class BatchCreateInstantSiteMonitorRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The site monitoring tasks.</para>
        /// <remarks>
        /// <para> You must create at least one site monitoring task. You must specify all of the <c>Address</c>, <c>TaskName</c>, and <c>TaskType</c> parameters in each request.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<BatchCreateInstantSiteMonitorRequestTaskList> TaskList { get; set; }
        public class BatchCreateInstantSiteMonitorRequestTaskList : TeaModel {
            /// <summary>
            /// <para>The URL or IP address that is monitored by the task.</para>
            /// <remarks>
            /// <para> You must create at least one site monitoring task. You must specify all of the <c>Address</c>, <c>TaskName</c>, and <c>TaskType</c> parameters in each request.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The detection points. If you leave this parameter empty, the system randomly selects three detection points.</para>
            /// <para>The value is a <c>JSON array</c>. Example: <c>{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}</c>. The values of the city field indicate Beijing, Hangzhou, and Qingdao.</para>
            /// <para>For information about how to obtain detection points, see <a href="https://help.aliyun.com/document_detail/115045.html">DescribeSiteMonitorISPCityList</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
            /// </summary>
            [NameInMap("IspCities")]
            [Validation(Required=false)]
            public string IspCities { get; set; }

            /// <summary>
            /// <para>The extended options of the protocol that is used by the site monitoring task. The options vary based on the protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;time_out&quot;:5000}</para>
            /// </summary>
            [NameInMap("OptionsJson")]
            [Validation(Required=false)]
            public string OptionsJson { get; set; }

            /// <summary>
            /// <para>The name of the site monitoring task.</para>
            /// <para>The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).</para>
            /// <remarks>
            /// <para> You must create at least one site monitoring task. You must specify all of the <c>Address</c>, <c>TaskName</c>, and <c>TaskType</c> parameters in each request.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HangZhou_ECS1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the site monitoring task.</para>
            /// <para>Valid values: HTTP, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.</para>
            /// <remarks>
            /// <para> You must create at least one site monitoring task. You must specify all of the <c>Address</c>, <c>TaskName</c>, and <c>TaskType</c> parameters in each request.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
