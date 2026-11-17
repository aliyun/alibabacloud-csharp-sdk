// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeliverToUserSlsRequest : TeaModel {
        /// <summary>
        /// <para>The list of product scopes for which delivery needs to be configured. Specify at least one item. You cannot create duplicate enabled delivery configurations for the same account and product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ProductType&quot;:&quot;CloudBrowser&quot;}]</para>
        /// </summary>
        [NameInMap("DeliveryScopes")]
        [Validation(Required=false)]
        public List<DeliverToUserSlsRequestDeliveryScopes> DeliveryScopes { get; set; }
        public class DeliverToUserSlsRequestDeliveryScopes : TeaModel {
            /// <summary>
            /// <para>The product type to which the logs belong. Specify the product type for which you want to enable log delivery. For example, <c>CloudBrowser</c> indicates Cloud Browser.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudBrowser</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

        }

        /// <summary>
        /// <para>The name of an existing SLS project. The name must start with <c>elastic-desktop-</c> and the project must already exist in the specified SLS region of the current account.</para>
        /// <para>Specify either this parameter or <c>ProjectName</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elastic-desktop-audit</para>
        /// </summary>
        [NameInMap("ExistedProjectName")]
        [Validation(Required=false)]
        public string ExistedProjectName { get; set; }

        /// <summary>
        /// <para>The name of the destination Logstore. The name must start with <c>elastic_desktop_</c>. If the Logstore does not exist, it is created. If the Logstore already exists, it is reused.</para>
        /// <para>If this parameter is not specified, the part after <c>elastic-desktop-</c> in the selected project name is used as a suffix to generate a name that starts with <c>elastic_desktop_</c>. For example, if the project name is <c>elastic-desktop-audit</c>, the default Logstore name is <c>elastic_desktop_audit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elastic_desktop_audit</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The name of the SLS project to be created or reused. The name must start with <c>elastic-desktop-</c>.</para>
        /// <para>Specify either this parameter or <c>ExistedProjectName</c>. If the project does not exist, it is created. If the project already exists, it is reused.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elastic-desktop-audit</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the destination SLS project is located. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// <para>The data retention period of the new Logstore. Unit: days.</para>
        /// <para><b>Valid values:</b> 1 to 3650.</para>
        /// <para><b>Default value:</b> 30.</para>
        /// <para>If an existing Logstore is reused, this operation does not update its data retention period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
