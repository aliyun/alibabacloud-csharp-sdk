// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorTrialConfigRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the AccessKey pair.</para>
        /// <remarks>
        /// <h2>You can call <a href="~~DescribeCloudVendorAccountAKList~~">DescribeCloudVendorAccountAKList</a> to obtain the AuthId.</h2>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2363</para>
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        /// <summary>
        /// <para>The multi-cloud configuration information:</para>
        /// <list type="bullet">
        /// <item><description><em>AWS</em>: Input parameters sqsQueueName and sqsRegion.</description></item>
        /// <item><description><em>Tencent</em>: Input parameters kafkaUserName, kafkaBootstrapServers, and kafkaTopic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;sqsRegion\&quot;:\&quot;us-west-2\&quot;,\&quot;sqsQueueName\&quot;:\&quot;****\&quot;}</para>
        /// </summary>
        [NameInMap("AuthInfo")]
        [Validation(Required=false)]
        public string AuthInfo { get; set; }

        /// <summary>
        /// <para>The cloud asset vendor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Azure.</description></item>
        /// <item><description><b>AWS</b>: AWS.</description></item>
        /// <item><description><b>VOLCENGINE</b>: Volcengine.</description></item>
        /// <item><description><b>google</b>: Google Cloud.</description></item>
        /// <item><description><b>CHAITIN</b>: Chaitin Technology.</description></item>
        /// <item><description><b>FORTINET</b>: Fortinet.</description></item>
        /// <item><description><b>THREATBOOK</b>: ThreatBook.</description></item>
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
