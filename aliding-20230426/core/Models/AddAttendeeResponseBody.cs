// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddAttendeeResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public AddAttendeeResponseBodyContent Content { get; set; }
        public class AddAttendeeResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public object Data { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorCtx")]
        [Validation(Required=false)]
        public Dictionary<string, object> ErrorCtx { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error check permissions</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BCC17ED-0187-54A0-BD31-56FDBE865447</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
