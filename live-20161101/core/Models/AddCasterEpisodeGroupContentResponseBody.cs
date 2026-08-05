// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupContentResponseBody : TeaModel {
        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public AddCasterEpisodeGroupContentResponseBodyItemIds ItemIds { get; set; }
        public class AddCasterEpisodeGroupContentResponseBodyItemIds : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public List<string> ItemId { get; set; }

        }

        /// <summary>
        /// <para>The program ID. You can use this ID as a request parameter when you create, add, delete, or query program items. You can also use this ID to edit, delete, query, start, or stop a program.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68X****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
