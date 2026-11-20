// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeSlsDeliveryConfigRequest : TeaModel {
        /// <summary>
        /// <para>Filters delivery scopes by the product type to which the logs belong. If this parameter is omitted or an empty list is passed, delivery scopes are not filtered by product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ProductType&quot;:&quot;WuyingServer&quot;}]</para>
        /// </summary>
        [NameInMap("DeliveryScopes")]
        [Validation(Required=false)]
        public List<DescribeSlsDeliveryConfigRequestDeliveryScopes> DeliveryScopes { get; set; }
        public class DescribeSlsDeliveryConfigRequestDeliveryScopes : TeaModel {
            /// <summary>
            /// <para>The query condition for the product type to which the logs belong. If you specify this parameter, the results are filtered by the specified product type, which must be consistent with the existing delivery configurations. For example, <c>WuyingServer</c> indicates Enterprise Edition workstations.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WuyingServer</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

        }

        /// <summary>
        /// <para>The name of the SLS Logstore. Exact match is used. If this parameter is omitted, the results are not filtered by Logstore name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wuying-session-audit</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The name of the SLS project. Exact match is used. If this parameter is omitted, the results are not filtered by project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wuying-audit-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SLS project is located. Exact match is used. If this parameter is omitted, the results are not filtered by region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

    }

}
