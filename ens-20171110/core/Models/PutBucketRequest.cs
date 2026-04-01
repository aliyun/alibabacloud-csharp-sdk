// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketRequest : TeaModel {
        /// <summary>
        /// <para>The access control list (ACL) of the bucket. private public-read-write public-read</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("BucketAcl")]
        [Validation(Required=false)]
        public string BucketAcl { get; set; }

        /// <summary>
        /// <para>The name of the bucket. This parameter can contain 3 to 50 characters in length and can contain only lowercase letters, digits, and hyphens (-). The name cannot start or end with a hyphen (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The description. The description can be 0 to 128 characters in length, and can contain Chinese characters and emoticons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>numb</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The scheduling scope. This parameter takes effect only when the value of the LogicalBucketType parameter is standard. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland.</description></item>
        /// <item><description><b>oversea</b>: outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("DispatchScope")]
        [Validation(Required=false)]
        public string DispatchScope { get; set; }

        /// <summary>
        /// <para>The ID of the region where the node is located. If this parameter is not specified, the node is the global default node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-15</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The type of the logical bucket. Valid values: sink standard (default)</para>
        /// 
        /// <b>Example:</b>
        /// <para>sink</para>
        /// </summary>
        [NameInMap("LogicalBucketType")]
        [Validation(Required=false)]
        public string LogicalBucketType { get; set; }

    }

}
