// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorTrialConfigRequest : TeaModel {
        /// <summary>
        /// <para>Unique ID of the AK.</para>
        /// <remarks>
        /// <h2>You can call <a href="~~DescribeCloudVendorAccountAKList~~">DescribeCloudVendorAccountAKList</a> to get the AuthId.</h2>
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
        /// <para>Enter multi-cloud configuration information:</para>
        /// <list type="bullet">
        /// <item><description><em>AWS</em>: Parameters include sqsQueueName, sqsRegion</description></item>
        /// <item><description><em>Tencent</em>: Parameters include kafkaUserName, kafkaBootstrapServers, kafkaTopic</description></item>
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
        /// <para>Cloud asset vendor. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
        /// <item><description><b>AWS</b>: AWS (Note: The original text incorrectly states \&quot;Microsoft\&quot;, which should be \&quot;AWS\&quot; based on context.)</description></item>
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
