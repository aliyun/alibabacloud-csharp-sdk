// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CheckDisposableResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDisposable")]
        [Validation(Required=false)]
        public string IsDisposable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFormatValid")]
        [Validation(Required=false)]
        public string IsFormatValid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMxValid")]
        [Validation(Required=false)]
        public string IsMxValid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOkToSend")]
        [Validation(Required=false)]
        public string IsOkToSend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
