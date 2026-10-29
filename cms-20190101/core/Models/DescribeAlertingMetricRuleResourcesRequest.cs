// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertingMetricRuleResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Queries alerts that occurred before this point in time. The value is a millisecond-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698827400000</para>
        /// </summary>
        [NameInMap("AlertBeforeTime")]
        [Validation(Required=false)]
        public string AlertBeforeTime { get; set; }

        /// <summary>
        /// <para>The dimension map used to query monitoring data of a specified resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;userId\&quot;:\&quot;120886317861****\&quot;,\&quot;region\&quot;:\&quot;cn-huhehaote\&quot;,\&quot;queue\&quot;:\&quot;test-0128\&quot;}</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The ID of the application group. For more information about how to query application group IDs, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7671****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The data namespace of the Alibaba Cloud service.</para>
        /// <para>For more information about how to obtain the data namespace of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_mns_new</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number. </para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule. For more information about how to query alert rule IDs, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>putNewAlarm_user_7e78d765-0e3e-4671-ba6d-7ce39108****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
