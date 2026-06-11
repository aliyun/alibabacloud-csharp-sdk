// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListFileUploadRequest : TeaModel {
        /// <summary>
        /// <para>For front-end use only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>仅前端使用</para>
        /// </summary>
        [NameInMap("CallFrom")]
        [Validation(Required=false)]
        public string CallFrom { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

        /// <summary>
        /// <para>The validity period of the download link, in seconds. This parameter applies only to files in user-owned Object Storage Service (OSS) buckets. The default is 3600.</para>
        /// <list type="bullet">
        /// <item><description><para>Minimum value: 3600 (1 hour)</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 129600 (36 hours)</para>
        /// </description></item>
        /// </list>
        /// <para>Notes:</para>
        /// <list type="bullet">
        /// <item><description><para>Download links for files in the built-in OSS are valid for 1 hour.</para>
        /// </description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("DownloadLinkExpire")]
        [Validation(Required=false)]
        public int? DownloadLinkExpire { get; set; }

        /// <summary>
        /// <para>The file category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TextReport</para>
        /// </summary>
        [NameInMap("FileCategory")]
        [Validation(Required=false)]
        public string FileCategory { get; set; }

        /// <summary>
        /// <para>The file source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent</para>
        /// </summary>
        [NameInMap("FileFrom")]
        [Validation(Required=false)]
        public string FileFrom { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-8*******01m</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h8r********4fch</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The sort column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreated</para>
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// <para>The sort direction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortDirection")]
        [Validation(Required=false)]
        public string SortDirection { get; set; }

    }

}
