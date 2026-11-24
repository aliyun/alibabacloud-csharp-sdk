// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiskAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of disk attachments.</para>
        /// </summary>
        [NameInMap("DiskAttachments")]
        [Validation(Required=false)]
        public List<DescribeDiskAttachmentsResponseBodyDiskAttachments> DiskAttachments { get; set; }
        public class DescribeDiskAttachmentsResponseBodyDiskAttachments : TeaModel {
            /// <summary>
            /// <para>The time when the disk was successfully attached, in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12T06:08:54Z</para>
            /// </summary>
            [NameInMap("AttachedTime")]
            [Validation(Required=false)]
            public string AttachedTime { get; set; }

            /// <summary>
            /// <para>The device name on the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The disk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp131n0q38u3a4zi****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the disk is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp18pnlg1ds9rky4****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of attachments returned in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that all attachments have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
