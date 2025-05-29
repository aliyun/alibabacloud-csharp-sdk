// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class DeviceRegisterRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2a64edd96296880f55aa61987b</para>
        /// </summary>
        [NameInMap("nonce")]
        [Validation(Required=false)]
        public string Nonce { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>el3SzmCU2p0x4RBc</para>
        /// </summary>
        [NameInMap("productKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748312544852</para>
        /// </summary>
        [NameInMap("requestTime")]
        [Validation(Required=false)]
        public string RequestTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3spKwUgUpAGsXbbrHKnpVJPlI9wamoyhh96uqJuSyCKyJ7oscLAHRcz15dSzLG5L+ywFgYXSQNqdRtsn/Ri0j7pD0IuoKt9R7EnNo/U6viPvWD3Ldp3ehDDtOFtSrpUg6LTedvGtUWYU4x/zSD2jgCXijEdZCCMGCypcheMHRXfInYWF1xFtnCEXJfxtrBrnCk1p/pW3JSmdHJzmInnUEO3dWbNe3A==</para>
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
