// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListCACertificateLogResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of operation logs for the CA certificate.</para>
        /// </summary>
        [NameInMap("LogList")]
        [Validation(Required=false)]
        public List<ListCACertificateLogResponseBodyLogList> LogList { get; set; }
        public class ListCACertificateLogResponseBodyLogList : TeaModel {
            /// <summary>
            /// <para>The description of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add sub-root ca</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time of the operation. This is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634539509000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160ae6bb538d538c70c01f81dcf2****</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The type of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ADD</b>: A CA certificate is created.</para>
            /// </description></item>
            /// <item><description><para><b>UPDATE</b>: The status of the CA certificate is updated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ADD</para>
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
