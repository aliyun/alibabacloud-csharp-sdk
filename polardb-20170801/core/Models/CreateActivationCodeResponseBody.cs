// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateActivationCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16 16:46:20</para>
        /// </summary>
        [NameInMap("ActivateAt")]
        [Validation(Required=false)]
        public string ActivateAt { get; set; }

        /// <summary>
        /// <para>The content of the activation code. Decode the Base64-encoded content and save it to the license.lic file for PolarDB to read during startup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAEAA******AAA=</para>
        /// </summary>
        [NameInMap("CertContentB64")]
        [Validation(Required=false)]
        public string CertContentB64 { get; set; }

        /// <summary>
        /// <para>The description of the activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testCode</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the activation code expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2054-10-09 16:46:20</para>
        /// </summary>
        [NameInMap("ExpireAt")]
        [Validation(Required=false)]
        public string ExpireAt { get; set; }

        /// <summary>
        /// <para>The time when the activation code was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16 16:46:20</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the activation code was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16 16:46:20</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// <para>The MAC address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:34:56:78:98:00</para>
        /// </summary>
        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// <para>The name of the activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CE6DF97-AEA4-484F-906F-C407EE******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the database, also known as the system identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("SystemIdentifier")]
        [Validation(Required=false)]
        public string SystemIdentifier { get; set; }

    }

}
