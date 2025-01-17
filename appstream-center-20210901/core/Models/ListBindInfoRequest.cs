// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBindInfoRequest : TeaModel {
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        [NameInMap("AppInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

        [NameInMap("WyIdList")]
        [Validation(Required=false)]
        public List<string> WyIdList { get; set; }

    }

}
