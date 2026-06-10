// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateDSEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The <c>entity ID</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23436345</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The <c>request ID</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adfad2343f1f2r</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
