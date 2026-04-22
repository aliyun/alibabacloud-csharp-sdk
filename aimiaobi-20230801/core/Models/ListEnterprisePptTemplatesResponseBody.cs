// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListEnterprisePptTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnterprisePptTemplatesResponseBodyData> Data { get; set; }
        public class ListEnterprisePptTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.com/a.png">http://xxx.com/a.png</a></para>
            /// </summary>
            [NameInMap("CoverImg")]
            [Validation(Required=false)]
            public string CoverImg { get; set; }

            /// <summary>
            /// <para>ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJANEQ4AACjMDLgAAADFTNzMyZDMwMzAzMDM4NzA3MjZjN2E2NDYyNzUzODMxMzY3ODM0NmIzNTZkNjc=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
