// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteGtmRecoveryPlanRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. The default value is <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the disaster recovery plan.&lt;props=&quot;intl&quot;&gt; To obtain the ID, call <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describegtmrecoveryplans?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeGtmRecoveryPlans</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10********</para>
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

    }

}
