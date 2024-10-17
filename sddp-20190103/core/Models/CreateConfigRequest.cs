// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The code of the common configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>access_failed_cnt</b>: the maximum number of access attempts allowed when Data Security Center (DSC) fails to access an unauthorized resource.</description></item>
        /// <item><description><b>access_permission_exprie_max_days</b>: the maximum idle period allowed for access permissions before an alert is triggered.</description></item>
        /// <item><description><b>log_datasize_avg_days</b>: the minimum percentage of the volume of logs of a specific type generated on the current day to the average volume of logs generated in the previous 10 days before an alert is triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>access_failed_cnt</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the common configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Maximum number of access attempts allowed when DSC fails to access an unauthorized resource: 10</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.170.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The value of the common configuration item. The meaning of this parameter varies with the value of the Code parameter.</para>
        /// <list type="bullet">
        /// <item><description>If you set the Code parameter to <b>access_failed_cnt</b>, the Value parameter specifies the maximum number of access attempts allowed when DSC fails to access an unauthorized resource.</description></item>
        /// <item><description>If you set the Code parameter to <b>access_permission_exprie_max_days</b>, the Value parameter specifies the maximum idle period allowed for access permissions before an alert is triggered.</description></item>
        /// <item><description>If you set the Code parameter to <b>log_datasize_avg_days</b>, the Value parameter specifies the minimum percentage of the volume of logs of a specific type generated on the current day to the average amount of logs generated in the previous 10 days before an alert is triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
