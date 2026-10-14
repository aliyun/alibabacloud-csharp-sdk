// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketRequest : TeaModel {
        /// <summary>
        /// <para>Bucket permission type: private (default). public-read-write: Allows public read and write access. public-read: Allows public read access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("BucketAcl")]
        [Validation(Required=false)]
        public string BucketAcl { get; set; }

        /// <summary>
        /// <para>Bucket name. Must be 3 to 50 characters long. Use only lowercase letters, numbers, and hyphens (-). Cannot start or end with a hyphen.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-bucket</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>Comment. Up to 128 characters, including letters, digits, Chinese characters, and emojis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Scheduling scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>domestic (within China)</para>
        /// </description></item>
        /// <item><description><para>outside China</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this parameter when creating a global bucket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sink</para>
        /// </summary>
        [NameInMap("DispatchScope")]
        [Validation(Required=false)]
        public string DispatchScope { get; set; }

        /// <summary>
        /// <para>Edge zone ID. If not specified, the global default edge zone is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx-xx-xx</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The logical type of the bucket. Valid values: sink: A sink bucket on a specified node. standard: A standard global bucket. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sink</para>
        /// </summary>
        [NameInMap("LogicalBucketType")]
        [Validation(Required=false)]
        public string LogicalBucketType { get; set; }

    }

}
