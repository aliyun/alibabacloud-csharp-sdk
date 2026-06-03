// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class CheckDomainResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Avail")]
        [Validation(Required=false)]
        public string Avail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nvgtntights.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DynamicCheck")]
        [Validation(Required=false)]
        public bool? DynamicCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Premium")]
        [Validation(Required=false)]
        public string Premium { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>In use</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AF7D4DCE-0776-47F2-A9B2-6FB85A87AA60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
