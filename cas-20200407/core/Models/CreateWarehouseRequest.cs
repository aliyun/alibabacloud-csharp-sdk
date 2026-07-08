// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateWarehouseRequest : TeaModel {
        /// <summary>
        /// <para>The use case of the certificate warehouse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>contract</para>
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// <para>The name of the certificate warehouse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCertificateWarehouse</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the certificate warehouse. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcaCertificate</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
