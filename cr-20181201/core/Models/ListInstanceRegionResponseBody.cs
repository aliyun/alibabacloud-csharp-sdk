// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListInstanceRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call is successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The list of regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListInstanceRegionResponseBodyRegions> Regions { get; set; }
        public class ListInstanceRegionResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China South 1 (Shenzhen)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11F182E1-0F84-4F5B-8D3B-61E991482727</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
