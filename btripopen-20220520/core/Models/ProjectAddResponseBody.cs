// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ProjectAddResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the newly created business travel project center. The value is null if the save operation fails or an exception occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23456</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public long? Module { get; set; }

        /// <summary>
        /// <para>Indicates whether more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        /// <summary>
        /// <para>The unique ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-<b><b>-</b></b>-****-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
