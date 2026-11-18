// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class LocationInfo : TeaModel {
        /// <summary>
        /// <para>The city associated with the search. It is used to return information about the corresponding region in scenarios such as weather.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The IP address associated with the search. It is used to identify the region in supported scenarios and has a lower priority than city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>117.136.110.23</para>
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

    }

}
