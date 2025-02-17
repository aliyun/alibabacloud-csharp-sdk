// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCloudVendorTrialConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the audit log configuration to be modified.</para>
        /// <remarks>
        /// <para>The ID can be queried via <a href="~~DescribeCloudVendorAccountAKList~~">DescribeCloudVendorAccountAKList</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23**</para>
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        /// <summary>
        /// <para>Enter the multi-cloud configuration information:</para>
        /// <list type="bullet">
        /// <item><description>AWS: parameters sqsQueueName, sqsRegion</description></item>
        /// <item><description>Tencent: parameters kafkaUserName, kafkaBootstrapServers, kafkaTopic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;sqsRegion\&quot;:\&quot;us-west-2\&quot;,\&quot;sqsQueueName\&quot;:\&quot;****\&quot;}</para>
        /// </summary>
        [NameInMap("AuthInfo")]
        [Validation(Required=false)]
        public string AuthInfo { get; set; }

        /// <summary>
        /// <para>Whether to delete this audit log configuration:</para>
        /// <list type="bullet">
        /// <item><description>true: Delete</description></item>
        /// <item><description>false: Do not delete</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteTrail")]
        [Validation(Required=false)]
        public bool? DeleteTrail { get; set; }

        /// <summary>
        /// <para>Cloud asset vendor. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
        /// <item><description><b>AWS</b>: AWS</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tencent</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
