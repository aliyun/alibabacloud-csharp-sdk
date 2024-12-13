// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ActiveCaCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>Public parameters, each request ID is unique and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SN serial number of the activated CA certificate, used to uniquely identify a CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>007269004887******</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
