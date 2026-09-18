// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class GenerateRelayPollerScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>The generation result, which contains the target identifier, the normalized platform, and the installation script.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateRelayPollerScriptResponseBodyData Data { get; set; }
        public class GenerateRelayPollerScriptResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The normalized target platform in the operating system-architecture format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>linux-amd64</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The installation script content (bash). The script contains a one-time access code, a temporary download link for the poller binary (signed and valid for 1 hour), and a checksum. The script does not contain the actual endpoint or credentials of the target, which are interactively entered during installation. The script carries access credential semantics. Transmit it through a trusted channel and re-download the script to obtain a new one after use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#!/bin/bash</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

            /// <summary>
            /// <para>The scan target identifier echoed from the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target-abc123def4567</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
