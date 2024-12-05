// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexOnlineStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The index change rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("changeRate")]
        [Validation(Required=false)]
        public int? ChangeRate { get; set; }

    }

}
