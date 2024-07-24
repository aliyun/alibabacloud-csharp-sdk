// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeColdStorageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ld-bp1uoihlf82e8****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorageSize")]
        [Validation(Required=false)]
        public string ColdStorageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BdsColdStorage</para>
        /// </summary>
        [NameInMap("ColdStorageType")]
        [Validation(Required=false)]
        public string ColdStorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20.00</para>
        /// </summary>
        [NameInMap("ColdStorageUseAmount")]
        [Validation(Required=false)]
        public string ColdStorageUseAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20.00</para>
        /// </summary>
        [NameInMap("ColdStorageUsePercent")]
        [Validation(Required=false)]
        public string ColdStorageUsePercent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("OpenStatus")]
        [Validation(Required=false)]
        public string OpenStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DCB9479E-F05F-4D1C-AFB7-C639B87764B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
