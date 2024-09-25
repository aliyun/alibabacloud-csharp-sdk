// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateAuthKeyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthYears")]
        [Validation(Required=false)]
        public int? AuthYears { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FACE_TEST</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Test")]
        [Validation(Required=false)]
        public bool? Test { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3iJ1AY$oHcu7mC69</para>
        /// </summary>
        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
