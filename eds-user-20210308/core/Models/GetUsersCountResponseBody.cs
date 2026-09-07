// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class GetUsersCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GroupCount")]
        [Validation(Required=false)]
        public int? GroupCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxUserNumber")]
        [Validation(Required=false)]
        public int? MaxUserNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>278</para>
        /// </summary>
        [NameInMap("OrgCount")]
        [Validation(Required=false)]
        public int? OrgCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9677D40F-0040-5956-A0EB-11B8B88****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public int? UserCount { get; set; }

    }

}
