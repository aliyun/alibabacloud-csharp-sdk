// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterQueryRequest : TeaModel {
        [NameInMap("disable")]
        [Validation(Required=false)]
        public long? Disable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("need_org_entity")]
        [Validation(Required=false)]
        public bool? NeedOrgEntity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cost1</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
