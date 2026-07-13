// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class RollbackGtmRecoveryPlanRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the disaster recovery plan.&lt;props=&quot;china&quot;&gt; Call the <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describegtmrecoveryplans?spm=a2c4g.11186623.help-menu-29697.d_0_5_1_3_13_5.6dd83618vW4yD7">DescribeGtmRecoveryPlans</a> operation to obtain the ID.
        /// &lt;props=&quot;intl&quot;&gt;Call the <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describegtmrecoveryplans?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeGtmRecoveryPlans</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10**</para>
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

    }

}
