// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeliverToUserSlsRequest : TeaModel {
        /// <summary>
        /// <para>List of delivery scopes</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;productType&quot;:&quot;China_China&quot;}]</para>
        /// </summary>
        [NameInMap("DeliveryScopes")]
        [Validation(Required=false)]
        public List<DeliverToUserSlsRequestDeliveryScopes> DeliveryScopes { get; set; }
        public class DeliverToUserSlsRequestDeliveryScopes : TeaModel {
            /// <summary>
            /// <para>product type</para>
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
        /// <para>Existing Simple Log Service project name; either this or ProjectName is required</para>
        /// 
        /// <b>Example:</b>
        /// <para>elastic-desktop-xxx</para>
        /// </summary>
        [NameInMap("ExistedProjectName")]
        [Validation(Required=false)]
        public string ExistedProjectName { get; set; }

        /// <summary>
        /// <para>LogStore name</para>
        /// 
        /// <b>Example:</b>
        /// <para>elastic_desktop_xxx</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>Simple Log Service project name; either this or ExistedProjectName is required</para>
        /// 
        /// <b>Example:</b>
        /// <para>elastic-desktop-xxx</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Region ID of Simple Log Service</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// <para>Data retention period (Day), default 30</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
