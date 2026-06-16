// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventVariableListRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The creation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>The filter object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;type&quot;: &quot;EXPRESSION&quot;,
        ///     &quot;name&quot;: &quot;ex_NgR6nDVD821c&quot;
        /// }</para>
        /// </summary>
        [NameInMap("filterDTO")]
        [Validation(Required=false)]
        public string FilterDTO { get; set; }

        /// <summary>
        /// <para>The associated event code (eventCode).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_awkhwh0314</para>
        /// </summary>
        [NameInMap("refObjId")]
        [Validation(Required=false)]
        public string RefObjId { get; set; }

        /// <summary>
        /// <para>The association type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EVENT</para>
        /// </summary>
        [NameInMap("refObjType")]
        [Validation(Required=false)]
        public string RefObjType { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NATIVE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
