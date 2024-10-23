// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUserBasicInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The <c>marker</c>. If part of a previous response is truncated, you can use this parameter to obtain the truncated part.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF2B25FD-CADE-445B-BE4D-E082E0FF1A0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the RAM user.</para>
        /// </summary>
        [NameInMap("UserBasicInfos")]
        [Validation(Required=false)]
        public ListUserBasicInfosResponseBodyUserBasicInfos UserBasicInfos { get; set; }
        public class ListUserBasicInfosResponseBodyUserBasicInfos : TeaModel {
            [NameInMap("UserBasicInfo")]
            [Validation(Required=false)]
            public List<ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfo> UserBasicInfo { get; set; }
            public class ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfo : TeaModel {
                /// <summary>
                /// <para>The display name of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20732900249392****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The logon name of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
                /// </summary>
                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

        }

    }

}
