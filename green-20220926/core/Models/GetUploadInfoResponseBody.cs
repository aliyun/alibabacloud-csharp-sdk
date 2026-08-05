// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The upload authorization ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI5t9HM*****EXQmw3DVH</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>The error code, which is consistent with the HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The expiration time. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/upload/xxx</para>
        /// </summary>
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public string Folder { get; set; }

        /// <summary>
        /// <para>The upload host.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cip-shanghai.oss-cn-shanghai.aliyuncs.com">https://oss-cip-shanghai.oss-cn-shanghai.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The key used for uploading the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/upload/xxx</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The further description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>Used by the frontend for image upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy for uploading files to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. This ID can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>STS token</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The signature information for the upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iyu7VHblYj+mEF9p46cdGOlNPAw=</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>The success flag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
