// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerTerminalResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c497b44c2a59f4ae0bd2826edc40a2c6e</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <para>The container name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker0</para>
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The name of the container group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775b9e0-8463-457e-89e8-fb7b6d125b2e</para>
        /// </summary>
        [NameInMap("Pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9732E117-8A37-49FD-A36F-ABBB87556CA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af22f4xxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The information about the shared token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af22f4-xxxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
