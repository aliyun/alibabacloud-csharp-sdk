// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKernelReleaseNotesRequest : TeaModel {
        /// <summary>
        /// <para>The minor version number of the instance. Example: <b>mongodb_20180522_0.4.8</b>.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required. After you specify a version number for this parameter in a request, the release notes of the versions later than this version are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mongodb_20180522_0.4.8</para>
        /// </summary>
        [NameInMap("KernelVersion")]
        [Validation(Required=false)]
        public string KernelVersion { get; set; }

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
