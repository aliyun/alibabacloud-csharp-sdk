// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListApplicationAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of AAPs.</para>
        /// </summary>
        [NameInMap("ApplicationAccessPoints")]
        [Validation(Required=false)]
        public ListApplicationAccessPointsResponseBodyApplicationAccessPoints ApplicationAccessPoints { get; set; }
        public class ListApplicationAccessPointsResponseBodyApplicationAccessPoints : TeaModel {
            [NameInMap("ApplicationAccessPoint")]
            [Validation(Required=false)]
            public List<ListApplicationAccessPointsResponseBodyApplicationAccessPointsApplicationAccessPoint> ApplicationAccessPoint { get; set; }
            public class ListApplicationAccessPointsResponseBodyApplicationAccessPointsApplicationAccessPoint : TeaModel {
                /// <summary>
                /// <para>The authentication method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ClientKey</para>
                /// </summary>
                [NameInMap("AuthenticationMethod")]
                [Validation(Required=false)]
                public string AuthenticationMethod { get; set; }

                /// <summary>
                /// <para>The name of the AAP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aap_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bcfefe15-46f0-44a3-bd96-3d422474b71a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
