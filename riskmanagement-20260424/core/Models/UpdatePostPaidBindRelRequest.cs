// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class UpdatePostPaidBindRelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public UpdatePostPaidBindRelRequestSdkRequest SdkRequest { get; set; }
        public class UpdatePostPaidBindRelRequestSdkRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AutoBindVersion")]
            [Validation(Required=false)]
            public int? AutoBindVersion { get; set; }

            [NameInMap("BindAction")]
            [Validation(Required=false)]
            public List<UpdatePostPaidBindRelRequestSdkRequestBindAction> BindAction { get; set; }
            public class UpdatePostPaidBindRelRequestSdkRequestBindAction : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BindAll")]
                [Validation(Required=false)]
                public bool? BindAll { get; set; }

                [NameInMap("UuidList")]
                [Validation(Required=false)]
                public List<string> UuidList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UpdateIfNecessary")]
            [Validation(Required=false)]
            public bool? UpdateIfNecessary { get; set; }

        }

    }

}
