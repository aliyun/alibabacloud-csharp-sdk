// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateAgentClientInstallResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the returned results.</para>
        /// </summary>
        [NameInMap("AegisCelintInstallResposeList")]
        [Validation(Required=false)]
        public List<OperateAgentClientInstallResponseBodyAegisCelintInstallResposeList> AegisCelintInstallResposeList { get; set; }
        public class OperateAgentClientInstallResponseBodyAegisCelintInstallResposeList : TeaModel {
            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf6j8vq9l4r5ntht****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the installation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2856</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1587bedb-fdb4-48c4-9330-****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE79B457-877C-51C6-AD72-0D34A025D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
