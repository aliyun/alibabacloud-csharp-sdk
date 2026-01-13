// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementConfigResponseBody : TeaModel {
        [NameInMap("NetworkConfigs")]
        [Validation(Required=false)]
        public List<GetRecallManagementConfigResponseBodyNetworkConfigs> NetworkConfigs { get; set; }
        public class GetRecallManagementConfigResponseBodyNetworkConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx">http://xxx</a></para>
            /// </summary>
            [NameInMap("PrivateLinkAddress")]
            [Validation(Required=false)]
            public string PrivateLinkAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Connecting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>scene_test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
