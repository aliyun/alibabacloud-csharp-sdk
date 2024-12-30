// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CdnFileDownloadCallbackInfo : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccp-bj1-bj-1234</para>
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md5.Sum([]byte(fmt.Sprintf(&quot;%v%v%v%v%v%v...%v&quot;, 		req.Object, req.Range, req.DomainID, req.DriveID, req.UserID, req.FileID, req.Expire)))</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
