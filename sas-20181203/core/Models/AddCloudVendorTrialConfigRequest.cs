// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorTrialConfigRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID.</para>
        /// <remarks>
        /// <para> <a href="#-describecloudvendoraccountaklist--authid"></a>You can call the <a href="~~DescribeCloudVendorAccountAKList~~">DescribeCloudVendorAccountAKList</a> operation to query the AccessKey ID.</para>
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
        /// <para>The configurations of the third-party cloud asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><em>AWS</em>: Configure the sqsQueueName and sqsRegion parameters.</description></item>
        /// <item><description><em>Tencent</em>: Configure the kafkaUserName, kafkaBootstrapServers, and kafkaTopic parameters.</description></item>
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
        /// <para>The service provider of the cloud asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud.</description></item>
        /// <item><description><b>AWS</b>: Amazon Web Services (AWS).</description></item>
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
