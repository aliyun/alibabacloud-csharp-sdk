// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>31000000****00000001</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("GbIp")]
        [Validation(Required=false)]
        public string GbIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5060</para>
        /// </summary>
        [NameInMap("GbPort")]
        [Validation(Required=false)]
        public long? GbPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>33763****77224964-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
