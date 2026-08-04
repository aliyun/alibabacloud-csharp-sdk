// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListIdpConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>IdP configurations.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIdpConfigsResponseBodyData Data { get; set; }
        public class ListIdpConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of IdP configurations.</para>
            /// </summary>
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListIdpConfigsResponseBodyDataDataList> DataList { get; set; }
            public class ListIdpConfigsResponseBodyDataDataList : TeaModel {
                /// <summary>
                /// <para>IdP configuration description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>IdP configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>277</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Multi-factor authentication (MFA) type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>totp</para>
                /// </summary>
                [NameInMap("Mfa")]
                [Validation(Required=false)]
                public string Mfa { get; set; }

                /// <summary>
                /// <para>Mobile login type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("MobileLoginType")]
                [Validation(Required=false)]
                public string MobileLoginType { get; set; }

                /// <summary>
                /// <para>Mobile MFA configuration type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("MobileMfaConfigType")]
                [Validation(Required=false)]
                public string MobileMfaConfigType { get; set; }

                /// <summary>
                /// <para>List of multiple IdP configuration IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1482,1355</para>
                /// </summary>
                [NameInMap("MultiIdpInfo")]
                [Validation(Required=false)]
                public string MultiIdpInfo { get; set; }

                /// <summary>
                /// <para>IdP configuration name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例身份源</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>PC login type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("PcLoginType")]
                [Validation(Required=false)]
                public string PcLoginType { get; set; }

                /// <summary>
                /// <para>IdP configuration enable status. Values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>IdP configuration type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingTalk</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-09T02:22:41.430Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD724DBC-CD76-5235-BF76-59C51B73296D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
