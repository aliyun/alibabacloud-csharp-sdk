// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100600017</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Owner not allowed to delete</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5BFFEE3-6025-443F-8A03-02D619B5C4B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
