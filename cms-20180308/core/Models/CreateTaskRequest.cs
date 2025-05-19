// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        [NameInMap("AlertRule")]
        [Validation(Required=false)]
        public string AlertRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("IntervalUnit")]
        [Validation(Required=false)]
        public string IntervalUnit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCity")]
        [Validation(Required=false)]
        public string IspCity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;http_method&quot;:&quot;get&quot;,&quot;header&quot;:&quot;xx=bb&quot;,&quot;cookie&quot;:&quot;test=aa&quot;,&quot;time_out&quot;:30000,&quot;match_rule&quot;:0,&quot;response_content&quot;:&quot;aa&quot;}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunTest</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>1.http
        /// 2.ping
        /// 3.tcp
        /// 4.udp
        /// 5.dns
        /// 6.smtp
        /// 7.pop3
        /// 8.ftp</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

    }

}
