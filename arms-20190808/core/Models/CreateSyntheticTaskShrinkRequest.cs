// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The common parameters.</para>
        /// </summary>
        [NameInMap("CommonParam")]
        [Validation(Required=false)]
        public string CommonParamShrink { get; set; }

        /// <summary>
        /// <para>The file download task.</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public string DownloadShrink { get; set; }

        /// <summary>
        /// <para>The frequency.</para>
        /// </summary>
        [NameInMap("ExtendInterval")]
        [Validation(Required=false)]
        public string ExtendIntervalShrink { get; set; }

        /// <summary>
        /// <para>The interval at which synthetic monitoring is performed. Unit: minutes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>5</description></item>
        /// <item><description>10</description></item>
        /// <item><description>15</description></item>
        /// <item><description>20</description></item>
        /// <item><description>30</description></item>
        /// <item><description>60</description></item>
        /// <item><description>120</description></item>
        /// <item><description>180</description></item>
        /// <item><description>240</description></item>
        /// <item><description>360</description></item>
        /// <item><description>480</description></item>
        /// <item><description>720</description></item>
        /// <item><description>1440</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public string IntervalTime { get; set; }

        /// <summary>
        /// <para>The interval type.</para>
        /// <list type="bullet">
        /// <item><description>0: daily</description></item>
        /// <item><description>1: custom frequency</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        /// <summary>
        /// <para>The IP address type:</para>
        /// <list type="bullet">
        /// <item><description>0: an automatic IP address</description></item>
        /// <item><description>1: IPv4</description></item>
        /// <item><description>2: IPv6</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public long? IpType { get; set; }

        /// <summary>
        /// <para>The list of monitoring points.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MonitorList")]
        [Validation(Required=false)]
        public string MonitorListShrink { get; set; }

        /// <summary>
        /// <para>The monitoring items that are associated with the browse tasks.</para>
        /// </summary>
        [NameInMap("Navigation")]
        [Validation(Required=false)]
        public string NavigationShrink { get; set; }

        /// <summary>
        /// <para>The network synthetic monitoring task.</para>
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public string NetShrink { get; set; }

        /// <summary>
        /// <para>The API performance synthetic monitoring task.</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string ProtocolShrink { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the application is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the task. To update a synthetic monitoring task, enter the task name and set the <b>UpdateTask</b> parameter to <b>true</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Network synthetic monitoring task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the monitoring task. Valid values:</para>
        /// <ol>
        /// <item><description>3: web page performance - IE</description></item>
        /// <item><description>34: web Page Performance - Chrome</description></item>
        /// <item><description>0: network quality</description></item>
        /// <item><description>40: file download</description></item>
        /// <item><description>7:API performance</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        /// <summary>
        /// <para>Specifies whether to update existing synthetic monitoring tasks.</para>
        /// <list type="bullet">
        /// <item><description>true: updates existing synthetic monitoring tasks.</description></item>
        /// <item><description>false: creates new synthetic monitoring tasks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdateTask")]
        [Validation(Required=false)]
        public bool? UpdateTask { get; set; }

        /// <summary>
        /// <para>The URL for synthetic monitoring.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
