// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateLifecycleRetrieveJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The directories or files that you want to retrieve. You can specify a maximum of 10 paths.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Paths.1=/pathway/doc1,Paths.2=/pathway/doc2</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// <para>The storage class.</para>
        /// <list type="bullet">
        /// <item><description>InfrequentAccess (default): the Infrequent Access (IA) storage class.</description></item>
        /// <item><description>Archive: the Archive storage class.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
