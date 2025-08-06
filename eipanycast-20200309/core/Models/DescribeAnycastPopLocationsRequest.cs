// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastPopLocationsRequest : TeaModel {
        /// <summary>
        /// <para>The access area of the Anycast elastic IP address (EIP).</para>
        /// <para>Set the value to <b>international</b>, which specifies the areas outside the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>international</para>
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

    }

}
