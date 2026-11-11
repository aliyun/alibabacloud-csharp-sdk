// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CreateReminderResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Detailed description of the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>不能设置过去的时间。</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The ID of the created reminder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20****1</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public long? Model { get; set; }

        /// <summary>
        /// <para>Indicates the result of the API call. true indicates success, and false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
