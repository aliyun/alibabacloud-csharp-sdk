// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecLogDeliveriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of API security log subscription.</para>
        /// </summary>
        [NameInMap("DeliveryConfigs")]
        [Validation(Required=false)]
        public List<DescribeApisecLogDeliveriesResponseBodyDeliveryConfigs> DeliveryConfigs { get; set; }
        public class DescribeApisecLogDeliveriesResponseBodyDeliveryConfigs : TeaModel {
            /// <summary>
            /// <para>The type of the log subscription. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>risk</b>: risk information.</description></item>
            /// <item><description><b>event</b>: attack event information.</description></item>
            /// <item><description><b>asset</b>: asset information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>risk</para>
            /// </summary>
            [NameInMap("AssertKey")]
            [Validation(Required=false)]
            public string AssertKey { get; set; }

            /// <summary>
            /// <para>The ID of the region where logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            /// <summary>
            /// <para>The name of the Logstore in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apisec-logstore***</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The name of the project in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apisec-project-14316572********</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The status of API security log subscription. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EFCFE18-78F8-5079-B312-07***48B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
