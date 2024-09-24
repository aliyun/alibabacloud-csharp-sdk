// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The monitoring data.</para>
        /// <para>Valid values of N: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataRequestMetricList> MetricList { get; set; }
        public class PutHybridMonitorMetricDataRequestMetricList : TeaModel {
            /// <summary>
            /// <para>The tags of the metric.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app、ip、hostName等标识信息</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutHybridMonitorMetricDataRequestMetricListLabels> Labels { get; set; }
            public class PutHybridMonitorMetricDataRequestMetricListLabels : TeaModel {
                /// <summary>
                /// <para>The tag key of the metric.</para>
                /// <para>Valid values of N: 1 to 100.</para>
                /// <para>The key can contain letters, digits, and underscores (<em>). The key must start with a letter or an underscore (</em>).</para>
                /// <remarks>
                /// <para> You must specify both the Key and Value parameters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>IP</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the metric.</para>
                /// <para>Valid values of N: 1 to 100.</para>
                /// <remarks>
                /// <para> You must specify both the Key and Value parameters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The metric name.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <para>The name can contain letters, digits, and underscores (_). The name must start with a letter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU_Usage</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the monitoring data is imported. The value is a timestamp.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <para>Unit: milliseconds. By default, the current time is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640776119473</para>
            /// </summary>
            [NameInMap("TS")]
            [Validation(Required=false)]
            public long? TS { get; set; }

            /// <summary>
            /// <para>The value of the metric.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <para>The value must be an integer or a floating-point number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>For information about how to obtain the name of a namespace, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-aliyun</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
