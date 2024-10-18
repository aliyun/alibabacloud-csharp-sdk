// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateVideoConferenceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>607452e01401526ee39609e1</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1151302294</para>
        /// </summary>
        [NameInMap("conferencePassword")]
        [Validation(Required=false)]
        public string ConferencePassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://pre-meeting.dingtalk.com/app?roomCode=68550708396&token=1_59209c43-431c-4e57-a0f8-11bebdb3db7f">https://pre-meeting.dingtalk.com/app?roomCode=68550708396&amp;token=1_59209c43-431c-4e57-a0f8-11bebdb3db7f</a></para>
        /// </summary>
        [NameInMap("externalLinkUrl")]
        [Validation(Required=false)]
        public string ExternalLinkUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2142817614</para>
        /// </summary>
        [NameInMap("hostPassword")]
        [Validation(Required=false)]
        public string HostPassword { get; set; }

        [NameInMap("phoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>3032809F-8C14-57E2-9B76-7AC2134FE3C8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("roomCode")]
        [Validation(Required=false)]
        public string RoomCode { get; set; }

    }

}
