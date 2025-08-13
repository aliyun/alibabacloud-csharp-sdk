// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventUploadPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>ID for accessing OSS</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI5tPXz8Y9tLVh5xxnnEAC</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>OSS host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.44</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The Key required for file upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/de/namelist/e924/ufzgsedX9bd3a7</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>OSS security policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAyNS0wNy0zMFQwNjowNTo0OS45NTRaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsMTA0ODU3NjAwMF0sWyJlcSIsIiRrZXkiLCJzYWZcL2RlXC9uYW1lbGlzdFwvZTkyNFwvdWZ6Z3NlZFg5Ymxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Signature data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7aXmkd2Z3oksCXOS9uvKlJuOKaY=</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>Temporary identity credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tT44bMQxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("StsToken")]
        [Validation(Required=false)]
        public string StsToken { get; set; }

    }

}
