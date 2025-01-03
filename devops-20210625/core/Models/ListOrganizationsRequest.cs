// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListOrganizationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("accessLevel")]
        [Validation(Required=false)]
        public int? AccessLevel { get; set; }

        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("minAccessLevel")]
        [Validation(Required=false)]
        public int? MinAccessLevel { get; set; }

    }

}
