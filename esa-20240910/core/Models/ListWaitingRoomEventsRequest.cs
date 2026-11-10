// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWaitingRoomEventsRequest : TeaModel {
        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The waiting room event ID. This parameter is optional and is used to query a specific waiting room event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89677721098****</para>
        /// </summary>
        [NameInMap("WaitingRoomEventId")]
        [Validation(Required=false)]
        public long? WaitingRoomEventId { get; set; }

        /// <summary>
        /// <para>The waiting room ID, which is used to identify a specific waiting room. You can call the <a href="https://help.aliyun.com/document_detail/2850279.html">ListWaitingRooms</a> operation to obtain the waiting room ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a51d5bc6460887abd129****</para>
        /// </summary>
        [NameInMap("WaitingRoomId")]
        [Validation(Required=false)]
        public string WaitingRoomId { get; set; }

    }

}
