// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of AD connectors.</para>
        /// </summary>
        [NameInMap("AdConnectors")]
        [Validation(Required=false)]
        public List<CreateADConnectorDirectoryResponseBodyAdConnectors> AdConnectors { get; set; }
        public class CreateADConnectorDirectoryResponseBodyAdConnectors : TeaModel {
            /// <summary>
            /// <para>The connection address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>127.0.**.**</c></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

        }

        /// <summary>
        /// <para>The ID of the AD directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-gx2x1dhsmu52rd****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE99D5E-93A1-493F-B1CB-0ABD4D05BEFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The AD trust password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82Tg****</para>
        /// </summary>
        [NameInMap("TrustPassword")]
        [Validation(Required=false)]
        public string TrustPassword { get; set; }

    }

}
