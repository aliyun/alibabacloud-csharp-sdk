// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSlbResponseBody : TeaModel {
        /// <summary>
        /// <para>The interface status or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlbList")]
        [Validation(Required=false)]
        public ListSlbResponseBodySlbList SlbList { get; set; }
        public class ListSlbResponseBodySlbList : TeaModel {
            [NameInMap("SlbEntity")]
            [Validation(Required=false)]
            public List<ListSlbResponseBodySlbListSlbEntity> SlbEntity { get; set; }
            public class ListSlbResponseBodySlbListSlbEntity : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Reusable")]
                [Validation(Required=false)]
                public bool? Reusable { get; set; }

                [NameInMap("SlbId")]
                [Validation(Required=false)]
                public string SlbId { get; set; }

                [NameInMap("SlbName")]
                [Validation(Required=false)]
                public string SlbName { get; set; }

                [NameInMap("SlbStatus")]
                [Validation(Required=false)]
                public string SlbStatus { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

    }

}
