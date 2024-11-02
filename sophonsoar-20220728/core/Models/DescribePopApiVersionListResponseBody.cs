// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiVersionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The POP code of the Alibaba Cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sas</para>
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBCDB0E1-4D0E-55A9-A44D-A62ADE7E2FDA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The information about the versions of API operations.</para>
        /// </summary>
        [NameInMap("VersionList")]
        [Validation(Required=false)]
        public List<DescribePopApiVersionListResponseBodyVersionList> VersionList { get; set; }
        public class DescribePopApiVersionListResponseBodyVersionList : TeaModel {
            /// <summary>
            /// <para>The name of the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DescribePopApiVersionList</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The POP code of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sas</para>
            /// </summary>
            [NameInMap("PopCode")]
            [Validation(Required=false)]
            public string PopCode { get; set; }

            /// <summary>
            /// <para>The version number of the API for the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-03</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
