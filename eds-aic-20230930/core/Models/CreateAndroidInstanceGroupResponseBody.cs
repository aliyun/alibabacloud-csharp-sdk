// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAndroidInstanceGroupResponseBody : TeaModel {
        [NameInMap("InstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIds { get; set; }

        [NameInMap("InstanceGroupInfos")]
        [Validation(Required=false)]
        public List<CreateAndroidInstanceGroupResponseBodyInstanceGroupInfos> InstanceGroupInfos { get; set; }
        public class CreateAndroidInstanceGroupResponseBodyInstanceGroupInfos : TeaModel {
            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22365781890****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
