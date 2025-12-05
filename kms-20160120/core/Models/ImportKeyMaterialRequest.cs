// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ImportKeyMaterialRequest : TeaModel {
        /// <summary>
        /// <para>Use <b>GetParametersForImport</b> the Returned public key and the base64-encoded key material.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bCPZx7I6v6KXsqEpr2OXKxuj2CCRtKdwp75Bw+BGncYqBdfjFBYRtOE6HRlT0oeiRDWzwnw9OA54OL36smDJrq4Lo9x0CyYDiuKnRkcKtMtlzW0din7Pd7IlZWWRdVueiw2qpzl7PkUWQGTdsdbzpfJJQ+qj/cRIrk/E83UGyeyytSpgnb+lu0xEYcPajRyWNsbi98N3pqqQzHXNNHO2NJqHlnQgglqTiBEjkGeKFhfKmTc3vjulIdVa3EaVIN6lwWfgx+UUYSrvbA77WDYKlDsZ4SbK2/T7za9Tp1qU7Ynqba7OKGVVj7PMbiaO80AxWZnjUMYCgEp5w7V+seOXqw==</para>
        /// </summary>
        [NameInMap("EncryptedKeyMaterial")]
        [Validation(Required=false)]
        public string EncryptedKeyMaterial { get; set; }

        /// <summary>
        /// <para>By calling <b>GetParametersForImport</b> the import token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64String</para>
        /// </summary>
        [NameInMap("ImportToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        /// <summary>
        /// <para>The ID of the CMK to be imported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234abcd-12ab-34cd-56ef-12345678****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The time when the key material expires.</para>
        /// <para>If this parameter is not specified or set this parameter to 0, the key material does not expire.</para>
        /// <remarks>
        /// <para> The value cannot be earlier than the time when the API is called (based on the server time).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("KeyMaterialExpireUnix")]
        [Validation(Required=false)]
        public long? KeyMaterialExpireUnix { get; set; }

    }

}
