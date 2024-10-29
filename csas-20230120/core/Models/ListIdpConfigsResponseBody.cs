// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListIdpConfigsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIdpConfigsResponseBodyData Data { get; set; }
        public class ListIdpConfigsResponseBodyData : TeaModel {
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListIdpConfigsResponseBodyDataDataList> DataList { get; set; }
            public class ListIdpConfigsResponseBodyDataDataList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>277</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>totp</para>
                /// </summary>
                [NameInMap("Mfa")]
                [Validation(Required=false)]
                public string Mfa { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("MobileLoginType")]
                [Validation(Required=false)]
                public string MobileLoginType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("MobileMfaConfigType")]
                [Validation(Required=false)]
                public string MobileMfaConfigType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1482,1355</para>
                /// </summary>
                [NameInMap("MultiIdpInfo")]
                [Validation(Required=false)]
                public string MultiIdpInfo { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("PcLoginType")]
                [Validation(Required=false)]
                public string PcLoginType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DingTalk</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-05-09T02:22:41.430Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FD724DBC-CD76-5235-BF76-59C51B73296D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
