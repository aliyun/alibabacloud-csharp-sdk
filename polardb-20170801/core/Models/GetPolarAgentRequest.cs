// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GetPolarAgentRequest : TeaModel {
        /// <summary>
        /// <para>Additional information, as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>The session query. Get this value from the return value of the &quot;Start a digital human&quot; API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4d242f3-c909-4846-91d9-f84c238a9820</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The session ID. Get this value from the return value of the &quot;Start a digital human&quot; API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4d242f3-c909-4846-91d9-f84c238a9820</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The product type source. Valid value: polardb-console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb-console</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
