// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindBatchAxgRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AxgBindList")]
        [Validation(Required=false)]
        public List<BindBatchAxgRequestAxgBindList> AxgBindList { get; set; }
        public class BindBatchAxgRequestAxgBindList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
            /// </summary>
            [NameInMap("ASRModelId")]
            [Validation(Required=false)]
            public string ASRModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ASRStatus")]
            [Validation(Required=false)]
            public bool? ASRStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CallDisplayType")]
            [Validation(Required=false)]
            public int? CallDisplayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CONTROL_AX_DISABLE</para>
            /// </summary>
            [NameInMap("CallRestrict")]
            [Validation(Required=false)]
            public string CallRestrict { get; set; }

            [NameInMap("ExpectCity")]
            [Validation(Required=false)]
            public string ExpectCity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-11 01:05:15</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("IsRecordingEnabled")]
            [Validation(Required=false)]
            public bool? IsRecordingEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18223ad447910fd</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20220824021816883677</para>
            /// </summary>
            [NameInMap("OutOrderId")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13333333333</para>
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13333333333</para>
            /// </summary>
            [NameInMap("PhoneNoB")]
            [Validation(Required=false)]
            public string PhoneNoB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13333333333</para>
            /// </summary>
            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;AXBRing_B\&quot;:\&quot;100000002\&quot;,\&quot;AXBRing_A\&quot;:\&quot;100000001\&quot;}</para>
            /// </summary>
            [NameInMap("RingConfig")]
            [Validation(Required=false)]
            public string RingConfig { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FC2235****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
