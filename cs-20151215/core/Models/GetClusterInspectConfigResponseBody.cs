// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterInspectConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of disabled inspection items.</para>
        /// </summary>
        [NameInMap("disabledCheckItems")]
        [Validation(Required=false)]
        public List<string> DisabledCheckItems { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable inspection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The inspection schedule defined through the RFC5545 Recurrence Rule syntax. You must specify BYHOUR and BYMINUTE. Only FREQ=DAILY is supported. COUNT and UNTIL are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREQ=DAILY;BYHOUR=10;BYMINUTE=15</para>
        /// </summary>
        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49511F2D-D56A-5C24-B9AE-C8491E09B095</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
