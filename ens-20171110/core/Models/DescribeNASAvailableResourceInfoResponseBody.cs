// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNASAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Business status code. Returns 0 on success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>you are not authorized to this workspace, or workspace not exists.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Available NAS resource information.</para>
        /// </summary>
        [NameInMap("NasAvailableResourceInfo")]
        [Validation(Required=false)]
        public List<DescribeNASAvailableResourceInfoResponseBodyNasAvailableResourceInfo> NasAvailableResourceInfo { get; set; }
        public class DescribeNASAvailableResourceInfoResponseBodyNasAvailableResourceInfo : TeaModel {
            /// <summary>
            /// <para>Edge zone product capabilities.</para>
            /// </summary>
            [NameInMap("Ability")]
            [Validation(Required=false)]
            public List<string> Ability { get; set; }

            /// <summary>
            /// <para>Area to which the ENS edge zone belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SouthWestChina</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <para>English name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chenzhou-telecom_unicom_cmcc</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <para>ENS edge zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chenzhou-telecom_unicom_cmcc</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>ENS edge zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China Hangzhou36</para>
            /// </summary>
            [NameInMap("EnsRegionName")]
            [Validation(Required=false)]
            public string EnsRegionName { get; set; }

            /// <summary>
            /// <para>Available NAS resource count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NasAvailableAmount")]
            [Validation(Required=false)]
            public int? NasAvailableAmount { get; set; }

            /// <summary>
            /// <para>Available NAS resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>capacity</para>
            /// </summary>
            [NameInMap("NasAvailableStorgeType")]
            [Validation(Required=false)]
            public string NasAvailableStorgeType { get; set; }

            /// <summary>
            /// <para>Province to which the ENS edge zone belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>湖北省</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
