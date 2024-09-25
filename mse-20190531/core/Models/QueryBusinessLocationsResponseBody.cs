// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryBusinessLocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryBusinessLocationsResponseBodyData> Data { get; set; }
        public class QueryBusinessLocationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Chinese name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Shanghai)</para>
            /// </summary>
            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Shanghai)</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Chinese name of the district.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia Pacific</para>
            /// </summary>
            [NameInMap("DistrictCnName")]
            [Validation(Required=false)]
            public string DistrictCnName { get; set; }

            /// <summary>
            /// <para>The English name of the district.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia Pacific</para>
            /// </summary>
            [NameInMap("DistrictEnName")]
            [Validation(Required=false)]
            public string DistrictEnName { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asia-pacific</para>
            /// </summary>
            [NameInMap("DistrictId")]
            [Validation(Required=false)]
            public string DistrictId { get; set; }

            /// <summary>
            /// <para>The ordering information of the district.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("DistrictOrdering")]
            [Validation(Required=false)]
            public int? DistrictOrdering { get; set; }

            /// <summary>
            /// <para>The display name of the district.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia Pacific</para>
            /// </summary>
            [NameInMap("DistrictShowName")]
            [Validation(Required=false)]
            public string DistrictShowName { get; set; }

            /// <summary>
            /// <para>The complete description of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China East 2 (Shanghai)</para>
            /// </summary>
            [NameInMap("EnDescription")]
            [Validation(Required=false)]
            public string EnDescription { get; set; }

            /// <summary>
            /// <para>The English name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Shanghai)</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ordering information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Ordering")]
            [Validation(Required=false)]
            public int? Ordering { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Shanghai)</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3369AD10-F1A6-4E6F-B99E-20F51826****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
