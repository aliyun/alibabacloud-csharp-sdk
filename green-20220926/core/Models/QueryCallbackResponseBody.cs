// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class QueryCallbackResponseBody : TeaModel {
        /// <summary>
        /// <para>Encryption algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHA256</para>
        /// </summary>
        [NameInMap("CryptType")]
        [Validation(Required=false)]
        public string CryptType { get; set; }

        /// <summary>
        /// <para>Whether there is an OSS detection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistsOssCheckTask")]
        [Validation(Required=false)]
        public bool? ExistsOssCheckTask { get; set; }

        /// <summary>
        /// <para>Creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-30 16:30:29</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>Modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-03 15:20:14</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Primary key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>回调通知</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>ID assigned by the backend, used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>Seed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb2MysbJTAAIf6gB3u4vpIEU-1ySnnf</para>
        /// </summary>
        [NameInMap("Seed")]
        [Validation(Required=false)]
        public string Seed { get; set; }

        /// <summary>
        /// <para>UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19964*****086772</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        /// <summary>
        /// <para>Callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyuncs.com">https://www.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
