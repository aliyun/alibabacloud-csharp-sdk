// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventVariableListRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. The values are: - <b>zh</b>: Chinese - <b>en</b>: English</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Create Type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Filter object.</para>
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
        /// <para>Associated event eventCode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_awkhwh0314</para>
        /// </summary>
        [NameInMap("refObjId")]
        [Validation(Required=false)]
        public string RefObjId { get; set; }

        /// <summary>
        /// <para>Association Type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EVENT</para>
        /// </summary>
        [NameInMap("refObjType")]
        [Validation(Required=false)]
        public string RefObjType { get; set; }

        /// <summary>
        /// <para>Region Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NATIVE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
