// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class GetTokenRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b504f84b69b9a73d3a21a2cff05e190</para>
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

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
        /// <para>1748413148546</para>
        /// </summary>
        [NameInMap("requestTime")]
        [Validation(Required=false)]
        public string RequestTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5/Smm8gnDSgZY2Blftq9eGYpVnpYCztoLJaJfhlH7id0lNlQxydRLtjUkGPr1qdbQq+oUn6Y1h0KJUdk0rf4am3MzdNr/Uhc47c8bbXnV8SlIC0agGo5skEQZNObzUD+sFxt8uN35/FYf7YRC8R61xY7+NPN2NLJrA/DPhewtVRRgAbb8RjergTcIG6oN1XTzLyC+76Az/3o2dPCxTfMXG3AFQc=</para>
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sk-4asv136677d2411b876e536bc8xxxxx</para>
        /// </summary>
        [NameInMap("tokenKey")]
        [Validation(Required=false)]
        public string TokenKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("tokenType")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
