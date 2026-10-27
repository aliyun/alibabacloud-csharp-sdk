// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddFileProtectBindMachineRequest : TeaModel {
        /// <summary>
        /// <para>The list of servers with the alert protection level enabled.</para>
        /// </summary>
        [NameInMap("AlertUuids")]
        [Validation(Required=false)]
        public List<string> AlertUuids { get; set; }

        /// <summary>
        /// <para>The list of servers with tamper-proofing enabled.</para>
        /// </summary>
        [NameInMap("BlockUuids")]
        [Validation(Required=false)]
        public List<string> BlockUuids { get; set; }

        /// <summary>
        /// <para>The list of servers with the file protection feature disabled.</para>
        /// </summary>
        [NameInMap("NoneUuids")]
        [Validation(Required=false)]
        public List<string> NoneUuids { get; set; }

    }

}
