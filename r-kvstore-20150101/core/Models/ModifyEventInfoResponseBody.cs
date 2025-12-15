// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyEventInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mst.errorcode.success.errormessage</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12343</para>
        /// </summary>
        [NameInMap("ErrorEventId")]
        [Validation(Required=false)]
        public string ErrorEventId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C9E114C-217C-4118-83C0-B4070222****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of successful records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The ID of the successful event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234221</para>
        /// </summary>
        [NameInMap("SuccessEventId")]
        [Validation(Required=false)]
        public string SuccessEventId { get; set; }

    }

}
