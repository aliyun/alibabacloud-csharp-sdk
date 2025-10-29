// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CancelPolarFsFileQuotaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>/path1,/path2</para>
        /// </summary>
        [NameInMap("FilePathIds")]
        [Validation(Required=false)]
        public string FilePathIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
