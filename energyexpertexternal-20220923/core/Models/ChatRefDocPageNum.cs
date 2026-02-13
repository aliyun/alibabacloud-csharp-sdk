// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRefDocPageNum : TeaModel {
        /// <summary>
        /// <para>Page numbers of content related to Q&amp;A.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        /// <summary>
        /// <para>List of location information for related documents.</para>
        /// </summary>
        [NameInMap("pos")]
        [Validation(Required=false)]
        public List<List<ChatRefDocPostion>> Pos { get; set; }

    }

}
