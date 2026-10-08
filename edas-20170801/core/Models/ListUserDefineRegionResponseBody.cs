// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListUserDefineRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the API call or a POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserDefineRegionList")]
        [Validation(Required=false)]
        public ListUserDefineRegionResponseBodyUserDefineRegionList UserDefineRegionList { get; set; }
        public class ListUserDefineRegionResponseBodyUserDefineRegionList : TeaModel {
            [NameInMap("UserDefineRegionEntity")]
            [Validation(Required=false)]
            public List<ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity> UserDefineRegionEntity { get; set; }
            public class ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity : TeaModel {
                [NameInMap("BelongRegion")]
                [Validation(Required=false)]
                public string BelongRegion { get; set; }

                [NameInMap("DebugEnable")]
                [Validation(Required=false)]
                public bool? DebugEnable { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("MseInstanceId")]
                [Validation(Required=false)]
                public string MseInstanceId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("RegistryType")]
                [Validation(Required=false)]
                public string RegistryType { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
