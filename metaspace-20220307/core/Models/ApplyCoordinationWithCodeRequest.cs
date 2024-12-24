// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Metaspace20220307.Models
{
    public class ApplyCoordinationWithCodeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PA3MU***</para>
        /// </summary>
        [NameInMap("CoordinationCode")]
        [Validation(Required=false)]
        public string CoordinationCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LoginRegionId")]
        [Validation(Required=false)]
        public string LoginRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v2c4e2ef03d62******</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>09e2b2e6-3181******</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A8B35215993FBF283F28D61******</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
