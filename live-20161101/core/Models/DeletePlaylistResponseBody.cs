// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeletePlaylistResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the episode list. You can use the ID as a request parameter in the API operation that is used to query the information about the episode list, start the episode list, or stop the episode list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b96****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
