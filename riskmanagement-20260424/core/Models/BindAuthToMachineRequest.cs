// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class BindAuthToMachineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public BindAuthToMachineRequestSdkRequest SdkRequest { get; set; }
        public class BindAuthToMachineRequestSdkRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            [NameInMap("Bind")]
            [Validation(Required=false)]
            public List<string> Bind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BindAll")]
            [Validation(Required=false)]
            public bool? BindAll { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;clientStatus\&quot;,\&quot;value\&quot;:\&quot;online\&quot;},{\&quot;name\&quot;:\&quot;authVersion\&quot;,\&quot;value\&quot;:\&quot;1\&quot;}]</para>
            /// </summary>
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public string Criteria { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPreBind")]
            [Validation(Required=false)]
            public int? IsPreBind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("LogicalExp")]
            [Validation(Required=false)]
            public string LogicalExp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>level2</para>
            /// </summary>
            [NameInMap("NtmVersion")]
            [Validation(Required=false)]
            public long? NtmVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>263076506250432</para>
            /// </summary>
            [NameInMap("PreBindOrderId")]
            [Validation(Required=false)]
            public long? PreBindOrderId { get; set; }

            [NameInMap("UnBind")]
            [Validation(Required=false)]
            public List<string> UnBind { get; set; }

        }

    }

}
