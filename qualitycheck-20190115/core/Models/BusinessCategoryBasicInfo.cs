// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class BusinessCategoryBasicInfo : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public int? Bid { get; set; }

        /// <summary>
        /// <para>Business name</para>
        /// 
        /// <b>Example:</b>
        /// <para>全部</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>originalId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OriginalId")]
        [Validation(Required=false)]
        public long? OriginalId { get; set; }

        /// <summary>
        /// <para>Service Type (ServiceCategory).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public int? ServiceType { get; set; }

    }

}
