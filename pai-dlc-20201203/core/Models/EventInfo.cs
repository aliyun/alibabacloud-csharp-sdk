// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class EventInfo : TeaModel {
        /// <summary>
        /// <para>The text content of the event.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the event, which is used to obtain the related context.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The ID of the pod to which the event belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc*****-master-0</para>
        /// </summary>
        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

        /// <summary>
        /// <para>The UID of the pod to which the event belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94a7cc7c-0033-48b5-85bd-71c63592c268</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        /// <summary>
        /// <para>The timestamp of the event in UTC.</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
