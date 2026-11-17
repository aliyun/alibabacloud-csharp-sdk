// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The requested region IDs.</para>
        /// </summary>
        [NameInMap("regions")]
        [Validation(Required=false)]
        public List<ListRegionsResponseBodyRegions> Regions { get; set; }
        public class ListRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The English name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("enName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shenzhen</para>
            /// </summary>
            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
