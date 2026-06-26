// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class PrepayResource : TeaModel {
        /// <summary>
        /// <para>The catalog ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clg-xxxx</para>
        /// </summary>
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The catalog name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_catalog</para>
        /// </summary>
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The number of CUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The time when the subscription expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1769356800000</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The time when the resources are purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764070447351</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The instance ID of computing resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-cu-quota-xxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the computing resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING
        /// UPGRADING
        /// CEASED
        /// RELEASED</para>
        /// </summary>
        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

    }

}
