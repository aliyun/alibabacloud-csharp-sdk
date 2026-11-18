// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The list of monitoring data.</para>
        /// <para>Valid values of N: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataRequestMetricList> MetricList { get; set; }
        public class PutHybridMonitorMetricDataRequestMetricList : TeaModel {
            /// <summary>
            /// <para>The list of labels for the metric.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <para>Identifiers such as app, ip, and hostName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Key&quot;:&quot;IP&quot;,&quot;Value&quot;:&quot;192.168.XX.XX&quot;}]</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutHybridMonitorMetricDataRequestMetricListLabels> Labels { get; set; }
            public class PutHybridMonitorMetricDataRequestMetricListLabels : TeaModel {
                /// <summary>
                /// <para>The label key of the metric.</para>
                /// <para>Valid values of N: 1 to 100.</para>
                /// <para>Format: The key can contain uppercase letters, lowercase letters, digits, and underscores (_). It must start with an uppercase letter, a lowercase letter, or an underscore.</para>
                /// <remarks>
                /// <para>You must specify both Key and Value.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>IP</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The label value of the metric.</para>
                /// <para>Valid values of N: 1 to 100.</para>
                /// <remarks>
                /// <para>You must specify both Key and Value.</para>
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
            /// <para>The name of the metric.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <para>Format: The name can contain uppercase letters, lowercase letters, digits, and underscores (_). It must start with an uppercase or lowercase letter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU_Usage</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The timestamp when the monitoring data is reported.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <para>Unit: milliseconds. Default value: the current time.</para>
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
            /// <para>Format: integer or floating-point number.</para>
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
        /// <para>The name of the metric namespace.</para>
        /// <para>For more information about how to obtain the name of a metric namespace, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
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
