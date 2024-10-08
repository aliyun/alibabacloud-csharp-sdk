// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCustomScenePoliciesResponseBody : TeaModel {
        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeCustomScenePoliciesResponseBodyDataModule> DataModule { get; set; }
        public class DescribeCustomScenePoliciesResponseBodyDataModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-06T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Objects")]
            [Validation(Required=false)]
            public List<string> Objects { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-04T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Expired</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>promotion</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public int? Quota { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>85H66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
