// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribePocOssTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID used to upload files to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>The host address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.34.191</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The key required for file upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/de/namelist/e924/ufzgsedX9bd3a7</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The OSS security policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpxxxcmF0aW9xxxIjoiMjAyNS0wNy0zMFQxxxxxwNjowNTo0OSxxxxx45NTRaIiwiY29uxxxZGl0a5Ymxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The signature information for the upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0lxQEWM0BqHd476JJE0fNXdS3UA=</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public bool? ResultObject { get; set; }

    }

}
