// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOssPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>accessId, a parameter used in OSS SDK uploads, corresponding to OSSAccessKeyId</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>OSS host ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testvm.biubiubiuu.com</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>Key required for file upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/a/uid/ccc</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>OSS security policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpxxxxxx</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>Signature data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tzl1wL4q8rR/xxxxxx</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
