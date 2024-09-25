// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The timestamp when the monitoring ends.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1666678376</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metric type. The following metric types are supported:</para>
        /// <para>[Basic system metrics]</para>
        /// <list type="bullet">
        /// <item><description>cpuUsage</description></item>
        /// <item><description>memoryUsage</description></item>
        /// <item><description>diskUsage</description></item>
        /// <item><description>gcCount</description></item>
        /// <item><description>gcTime</description></item>
        /// </list>
        /// <para>[Nacos registry]</para>
        /// <list type="bullet">
        /// <item><description>serviceCount</description></item>
        /// <item><description>writeCostTime</description></item>
        /// <item><description>readCostTime</description></item>
        /// <item><description>TPS regCenterTps</description></item>
        /// <item><description>QPS regCenterQps</description></item>
        /// </list>
        /// <para>[Nacos configuration center]</para>
        /// <list type="bullet">
        /// <item><description>publish</description></item>
        /// <item><description>getConfig</description></item>
        /// </list>
        /// <para>[zookeeper]</para>
        /// <list type="bullet">
        /// <item><description>TPS zk_TpsCount</description></item>
        /// <item><description>QPS zk_QpsCount</description></item>
        /// <item><description>zookeeper_AvgRequestLatency</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>regCenterQps</para>
        /// </summary>
        [NameInMap("MonitorType")]
        [Validation(Required=false)]
        public string MonitorType { get; set; }

        /// <summary>
        /// <para>The extended request parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The timestamp when the monitoring starts.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1666678376</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The interval between data points. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

    }

}
