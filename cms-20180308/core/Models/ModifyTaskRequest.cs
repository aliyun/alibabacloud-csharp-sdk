// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class ModifyTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5e9b-4c12-b39e-7f277ac44b11</para>
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;alarmActions&quot;:&quot;xxx&quot;,&quot;metricName&quot;:&quot;Availability&quot;,&quot;expression&quot;:&quot;$Availability&lt;96&quot;}]</para>
        /// </summary>
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
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCity")]
        [Validation(Required=false)]
        public string IspCity { get; set; }

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
        /// <para>8f880e3d-d924-47ab-84d2-fa1a72e24211</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyunTest</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cms</para>
        /// </summary>
        [NameInMap("caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

    }

}
