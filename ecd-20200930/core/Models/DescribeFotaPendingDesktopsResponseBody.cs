// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaPendingDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The cloud computers whose images can be and are pending to be updated to the version specified in <c>TaskUid</c>.</para>
        /// </summary>
        [NameInMap("FotaPendingDesktops")]
        [Validation(Required=false)]
        public List<DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops> FotaPendingDesktops { get; set; }
        public class DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops : TeaModel {
            /// <summary>
            /// <para>The current version of the image used by the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1-D-20220513.143129</para>
            /// </summary>
            [NameInMap("CurrentAppVersion")]
            [Validation(Required=false)]
            public string CurrentAppVersion { get; set; }

            /// <summary>
            /// <para>The ID of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-bvdtu3jn97o1r****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestDesktop</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>To be hidden</para>
            /// </summary>
            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            /// <summary>
            /// <para>The ID of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-815419****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The connected sessions.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktopsSessions> Sessions { get; set; }
            public class DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktopsSessions : TeaModel {
                /// <summary>
                /// <para>The ID of the end user that connects to the cloud computer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>end user id</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

            }

            /// <summary>
            /// <para>The status of the cloud computer.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The cloud computer is being created.</description></item>
            /// <item><description>1: The cloud computer is being started.</description></item>
            /// <item><description>2: The cloud computer is running.</description></item>
            /// <item><description>3: The cloud computer is being stopped.</description></item>
            /// <item><description>5: The cloud computer is stopped.</description></item>
            /// <item><description>6: The cloud computer expires.</description></item>
            /// <item><description>7: The cloud computer is deleted.</description></item>
            /// <item><description>9: Failed to create the cloud computer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
