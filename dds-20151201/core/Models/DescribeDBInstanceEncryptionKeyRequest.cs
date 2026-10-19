// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceEncryptionKeyRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp2235****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The custom encryption key of the instance. You can call <a href="https://help.aliyun.com/document_detail/151729.html">DescribeUserEncryptionKeyList</a> to query the custom keys of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2axxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The key scenario to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TDE: Queries transparent data encryption key information.</description></item>
        /// <item><description>CloudDisk: Queries cloud disk encryption key information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TDE</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
