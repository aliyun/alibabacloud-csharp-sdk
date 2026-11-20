// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeSlsDeliveryConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of delivery configurations that match the filter conditions. If no configurations match the conditions, an empty list is returned.</para>
        /// </summary>
        [NameInMap("DeliveryConfigs")]
        [Validation(Required=false)]
        public List<DescribeSlsDeliveryConfigResponseBodyDeliveryConfigs> DeliveryConfigs { get; set; }
        public class DescribeSlsDeliveryConfigResponseBodyDeliveryConfigs : TeaModel {
            /// <summary>
            /// <para>The list of Logstore delivery configurations under the project.</para>
            /// </summary>
            [NameInMap("LogStores")]
            [Validation(Required=false)]
            public List<DescribeSlsDeliveryConfigResponseBodyDeliveryConfigsLogStores> LogStores { get; set; }
            public class DescribeSlsDeliveryConfigResponseBodyDeliveryConfigsLogStores : TeaModel {
                /// <summary>
                /// <para>The product delivery scopes of the Logstore and the delivery status of each scope.</para>
                /// </summary>
                [NameInMap("DeliveryScopes")]
                [Validation(Required=false)]
                public List<DescribeSlsDeliveryConfigResponseBodyDeliveryConfigsLogStoresDeliveryScopes> DeliveryScopes { get; set; }
                public class DescribeSlsDeliveryConfigResponseBodyDeliveryConfigsLogStoresDeliveryScopes : TeaModel {
                    /// <summary>
                    /// <para>The product type of the delivery scope. For example, <c>WuyingServer</c> indicates Enterprise Edition workstations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WuyingServer</para>
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// <para>The current status of the delivery configuration. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>Stopped</c>: Delivery is stopped.</description></item>
                    /// <item><description><c>Enabled</c>: Delivery is enabled.</description></item>
                    /// <item><description><c>AbnormalLogstoreDeleted</c>: Delivery is abnormal because the destination Logstore is deleted.</description></item>
                    /// <item><description><c>AbnormalProjectDeleted</c>: Delivery is abnormal because the destination project is deleted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enabled</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The name of the destination SLS Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wuying-session-audit</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The data retention period configured for the destination Logstore, in days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The name of the destination SLS project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wuying-audit-cn-hangzhou</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The ID of the region where the destination SLS project is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SlsRegionId")]
            [Validation(Required=false)]
            public string SlsRegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
