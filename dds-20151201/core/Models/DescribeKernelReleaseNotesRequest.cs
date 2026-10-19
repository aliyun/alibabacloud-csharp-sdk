// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKernelReleaseNotesRequest : TeaModel {
        /// <summary>
        /// <para>The minor engine version of the database. Example: <b>mongodb_20180522_0.4.8</b>.</para>
        /// <para>You can obtain the minor engine version in the <b>Specifications</b> section on the <b>Basic Information</b> page of the instance in the MongoDB console.</para>
        /// <remarks>
        /// <para>This parameter is required. The response includes a list of versions that are later than the specified version.</para>
        /// </remarks>
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
