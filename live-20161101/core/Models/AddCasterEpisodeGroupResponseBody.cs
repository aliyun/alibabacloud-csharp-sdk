// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupResponseBody : TeaModel {
        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public AddCasterEpisodeGroupResponseBodyItemIds ItemIds { get; set; }
        public class AddCasterEpisodeGroupResponseBodyItemIds : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public List<string> ItemId { get; set; }

        }

        /// <summary>
        /// <para>The program list ID. This ID can be used as a request parameter for deleting a production studio program list, creating or adding program list items, deleting program list items, querying program list items, editing a program list, deleting a program list, querying a program list, starting a program list, or stopping a program list.</para>
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
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
