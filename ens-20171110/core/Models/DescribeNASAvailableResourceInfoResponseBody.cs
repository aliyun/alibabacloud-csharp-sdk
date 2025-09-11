// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNASAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>you are not authorized to this workspace, or workspace not exists.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NasAvailableResourceInfo")]
        [Validation(Required=false)]
        public List<DescribeNASAvailableResourceInfoResponseBodyNasAvailableResourceInfo> NasAvailableResourceInfo { get; set; }
        public class DescribeNASAvailableResourceInfoResponseBodyNasAvailableResourceInfo : TeaModel {
            [NameInMap("Ability")]
            [Validation(Required=false)]
            public List<string> Ability { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SouthWestChina</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-chenzhou-telecom_unicom_cmcc</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-chenzhou-telecom_unicom_cmcc</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            [NameInMap("EnsRegionName")]
            [Validation(Required=false)]
            public string EnsRegionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NasAvailableAmount")]
            [Validation(Required=false)]
            public int? NasAvailableAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>capacity</para>
            /// </summary>
            [NameInMap("NasAvailableStorgeType")]
            [Validation(Required=false)]
            public string NasAvailableStorgeType { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
