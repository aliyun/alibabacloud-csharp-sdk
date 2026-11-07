// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Language type for returned information:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Sorting. This field is currently unavailable and being deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DescSort")]
        [Validation(Required=false)]
        public bool? DescSort { get; set; }

        /// <summary>
        /// <para>Filter conditions in the format {&quot;key1&quot;:&quot;value1&quot;}</para>
        /// </summary>
        [NameInMap("FilterParams")]
        [Validation(Required=false)]
        public string FilterParamsShrink { get; set; }

        /// <summary>
        /// <para>Sorting property.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreate</para>
        /// </summary>
        [NameInMap("OrderItem")]
        [Validation(Required=false)]
        public string OrderItem { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of instances displayed per page (currently not in effect, queries all instances by default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
