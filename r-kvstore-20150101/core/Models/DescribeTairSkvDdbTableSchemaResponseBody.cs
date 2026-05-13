// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairSkvDdbTableSchemaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A1604E1B-6825-1577-BBDA-2A64E8D5F126</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;attributeDefinitions&quot;:[{&quot;attributeType&quot;:&quot;S&quot;,&quot;attributeName&quot;:&quot;pk&quot;},{&quot;attributeType&quot;:&quot;S&quot;,&quot;attributeName&quot;:&quot;sk&quot;}],&quot;keySchema&quot;:[{&quot;attributeName&quot;:&quot;pk&quot;,&quot;keyType&quot;:&quot;HASH&quot;},{&quot;attributeName&quot;:&quot;sk&quot;,&quot;keyType&quot;:&quot;RANGE&quot;}]}</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;attributeName&quot;:&quot;Expiretime&quot;,&quot;enabled&quot;:true}</para>
        /// </summary>
        [NameInMap("TtlSpec")]
        [Validation(Required=false)]
        public string TtlSpec { get; set; }

    }

}
