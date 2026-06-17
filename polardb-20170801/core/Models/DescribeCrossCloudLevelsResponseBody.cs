// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudLevelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of supported cross-cloud specifications.</para>
        /// </summary>
        [NameInMap("CrossCloudLevelList")]
        [Validation(Required=false)]
        public List<DescribeCrossCloudLevelsResponseBodyCrossCloudLevelList> CrossCloudLevelList { get; set; }
        public class DescribeCrossCloudLevelsResponseBodyCrossCloudLevelList : TeaModel {
            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The specification code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.g4.medium.c</para>
            /// </summary>
            [NameInMap("LevelCode")]
            [Validation(Required=false)]
            public string LevelCode { get; set; }

            /// <summary>
            /// <para>The CPU and memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2 core 8 GB</para>
            /// </summary>
            [NameInMap("LevelName")]
            [Validation(Required=false)]
            public string LevelName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
