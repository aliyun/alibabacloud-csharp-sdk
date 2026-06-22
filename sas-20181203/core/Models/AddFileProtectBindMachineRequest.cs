// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddFileProtectBindMachineRequest : TeaModel {
        /// <summary>
        /// <para>The list of servers for which the alert protection level is enabled.</para>
        /// </summary>
        [NameInMap("AlertUuids")]
        [Validation(Required=false)]
        public List<string> AlertUuids { get; set; }

        /// <summary>
        /// <para>The list of servers for which tamper-proofing is enabled.</para>
        /// </summary>
        [NameInMap("BlockUuids")]
        [Validation(Required=false)]
        public List<string> BlockUuids { get; set; }

        /// <summary>
        /// <para>The list of servers for which file protection is disabled.</para>
        /// </summary>
        [NameInMap("NoneUuids")]
        [Validation(Required=false)]
        public List<string> NoneUuids { get; set; }

    }

}
