// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRefDocInfo : TeaModel {
        /// <summary>
        /// <para>Detailed information for each page of the document.</para>
        /// </summary>
        [NameInMap("pageListInfo")]
        [Validation(Required=false)]
        public List<ChatRefDocPageInfo> PageListInfo { get; set; }

        /// <summary>
        /// <para>Total number of pages in the current document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("pages")]
        [Validation(Required=false)]
        public long? Pages { get; set; }

    }

}
