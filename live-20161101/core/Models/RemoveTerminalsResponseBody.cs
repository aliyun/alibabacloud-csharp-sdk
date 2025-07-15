// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RemoveTerminalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4AF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the users.</para>
        /// </summary>
        [NameInMap("Terminals")]
        [Validation(Required=false)]
        public List<RemoveTerminalsResponseBodyTerminals> Terminals { get; set; }
        public class RemoveTerminalsResponseBodyTerminals : TeaModel {
            /// <summary>
            /// <para>The returned status code. A value of 0 indicates that the request is successful. If the request fails, an error message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1811****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The result of removing the specified users from the channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
