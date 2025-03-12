// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSessionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The object information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSessionListResponseBodyData> Data { get; set; }
        public class DescribeSessionListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The address of the client, with the format ip:port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.***.**.100:80</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The session ID of the proxy service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d2c90ad0-bc54-410f-bb89-2dcf14aa3c6d</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
