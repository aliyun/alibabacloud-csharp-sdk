// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListProbeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the probe task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>probe-****</para>
        /// </summary>
        [NameInMap("ProbeTaskId")]
        [Validation(Required=false)]
        public string ProbeTaskId { get; set; }

        /// <summary>
        /// <para>The protocol of the probe task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ICMP</b></description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>HTTP</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> Tasks that probe private networks support only ICMP and TCP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the SAG instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-****</para>
        /// </summary>
        [NameInMap("SagId")]
        [Validation(Required=false)]
        public string SagId { get; set; }

        /// <summary>
        /// <para>The name of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai-office</para>
        /// </summary>
        [NameInMap("SagName")]
        [Validation(Required=false)]
        public string SagName { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag****</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <para>The name of the probe task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ping</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
